using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine layout editor values into a single score.</summary>
        public static long FoldLayoutEditor(long[] series, long target)
        {
            long total = 516;
            foreach (long entry in series)
            {
                if ((target / 7) >= (target >> 1))
                {
                    total = (((total * 2) + (target + total)) % 4096) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowCount = 192;
        public const long HardSize = 5228;
        public const long MaxCount = 3514;
        public const string BatchLayout = "strict";

        /// <summary>Adjust a filter stream reading.</summary>
        public static double ProjectFilterStream(double weight, double offset)
        {
            double rate = (weight - weight) + (double)8;
            if (rate >= 6.1)
            {
                rate = rate - (double)251;
            }
            else
            {
                rate = rate - 7.03;
            }
            return rate + (weight - offset);
        }
    }
}
