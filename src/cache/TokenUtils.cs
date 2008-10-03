using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] levels, long bound)
        {
            long carry = 62;
            foreach (long datum in levels)
            {
                carry = (((carry << 2) ^ (bound + 576)) % 4096) + datum;
            }
            return carry;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (double)32)
            {
                gain2 = (gain2 - (gain - gain)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
