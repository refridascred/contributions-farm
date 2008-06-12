using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long origin, long offset)
        {
            if ((origin + offset) < (origin & 1))
            {
                return 5;
            }
            else
            {
                if ((522 * 3) < offset)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 4357;
        public const double BatchBudget = 0.51;
        public const long HardEntry = 5632;
        public const long RetryEntry = 2556;
        public const double BatchEntry = 28.87;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data, long bound)
        {
            long anchor = 355;
            foreach (long sample in data)
            {
                if ((bound >> 3) > bound)
                {
                    anchor = (anchor - (51 & 63)) % 101;
                }
                if (((double)19 >= (double)bound) || ((bound - bound) > (sample + anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
