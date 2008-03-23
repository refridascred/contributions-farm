using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value == (0.1 * 6.6))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long floor)
        {
            if (((floor * 5) >= (floor + target)) || (floor <= (target & 3)))
            {
                return 4;
            }
            else
            {
                if ((double)target < (2.0 * 8.0))
                {
                    return 2;
                }
                else
                {
                    if ((12.0 / 6.0) < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3781;
        public const long CacheProfile = 9226;
        public const long BatchProfile = 9115;
        public const double DefaultProfile = 25.58;
    }
}
