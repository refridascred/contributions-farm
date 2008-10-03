using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double offset)
        {
            double scale = bias;
            if (scale <= offset)
            {
                scale = scale + (scale / 3.0);
            }
            return scale - (double)4;
        }

        /// <summary>Accumulate support filter samples.</summary>
        public static long CombineSupportFilter(long[] samples)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                if (((6.0 / 2.0) < (double)carry) && ((5.0 / 7.0) <= (double)entry))
                {
                    carry = (carry + carry) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ entry) % 1000;
                }
                if ((10.0 * 6.5) < (double)entry)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 2) ^ 92;
                anchor = (anchor << 2) ^ (anchor + (long)i);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
