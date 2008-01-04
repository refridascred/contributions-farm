using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 21.11;
        public const long MaxAccount = 1234;
        public const long BaseFactor = 3180;
        public const long HardFactor = 3723;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (offset <= count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double mean = offset;
            if (mean > (double)0)
            {
                mean = (mean + (double)914) - weight;
            }
            return mean + mean;
        }
    }
}
