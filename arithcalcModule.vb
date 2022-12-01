Module arithcalcModule
    Dim X, Ab, Ac, Ba, Bb, Ca, Cb, Da, Db, Dc, Ea, Eb As Primitive
    Sub Main()
        TextWindow.WriteLine("Welcome to the Basic Mathematical Arithmetic Calculator!")
        TextWindow.WriteLine("Choose the one of your required equations to use!")
        TextWindow.WriteLine("(A) Absolute Value")
        TextWindow.WriteLine("(B) Floor Function (integer)")
        TextWindow.WriteLine("(C) Square Root")
        TextWindow.WriteLine("(D) Exponent (power of 2)")
        TextWindow.WriteLine("(E) Round-off")
        X = TextWindow.Read()
        If X = CType("a", Primitive) Then
            TextWindow.Clear()
            TextWindow.WriteLine("Enter a number to get its absolute value:")
            Ab = TextWindow.ReadNumber()
            Ac = Microsoft.SmallBasic.Library.Math.Abs(Ab)
            TextWindow.WriteLine(Ac)
        ElseIf X = CType("b", Primitive) Then
            TextWindow.Clear()
            TextWindow.WriteLine("Enter a number to get its floor value of integer:")
            Ba = TextWindow.ReadNumber()
            Bb = Microsoft.SmallBasic.Library.Math.Floor(Ba)
            TextWindow.WriteLine(Bb)
        ElseIf X = CType("c", Primitive) Then
            TextWindow.Clear()
            TextWindow.WriteLine("Enter a number to get its square root:")
            Ca = TextWindow.ReadNumber()
            Cb = Microsoft.SmallBasic.Library.Math.SquareRoot(Ca)
            TextWindow.WriteLine(Cb)
        ElseIf X = CType("d", Primitive) Then
            TextWindow.Clear()
            TextWindow.WriteLine("Enter a number and an exponent of it:")
            Da = TextWindow.ReadNumber()
            Db = TextWindow.ReadNumber()
            Dc = Microsoft.SmallBasic.Library.Math.Power(Da, Db)
            TextWindow.WriteLine(Dc)
        ElseIf X = CType("e", Primitive) Then
            TextWindow.Clear()
            TextWindow.WriteLine("Enter a number to get the value of round-off'd number:")
            Ea = TextWindow.ReadNumber()
            Eb = Microsoft.SmallBasic.Library.Math.Round(Ea)
            TextWindow.WriteLine(Eb)
        End If
    End Sub
End Module
