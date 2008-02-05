using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen <= (item + item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
