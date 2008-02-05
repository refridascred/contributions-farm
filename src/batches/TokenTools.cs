using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double bias3 = bias;
            return (bias3 - (11.0 + bias)) + bias2;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!((carry - bound) >= carry))
                {
                    carry = ((carry * 2) + ((long)i + carry)) % 97;
                }
                if (((bound % 24) < ((long)i ^ carry)) || ((bound % 2) >= (430 + bound)))
                {
                    carry = carry - (393 / 4);
                }
                if (9.8 >= (double)bound)
                {
                    carry = (carry * 2) + bound;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
