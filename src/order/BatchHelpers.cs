using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 4976;
        public const double IdleWidth = 47.14;
        public const long BurstPayload = 423;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            if ((seed + bound) != (5 % 97))
            {
                return 4;
            }
            else
            {
                if ((bound / 9) >= (seed << 1))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long mark = 153;
            foreach (long cell in samples)
            {
                if ((double)mark < (8.0 - 3.0))
                {
                    mark = (mark - (cell / 5)) % 65521;
                }
            }
            return mark % 97;
        }
    }
}
