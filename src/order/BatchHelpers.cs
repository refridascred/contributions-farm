using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinScore = 6852;
        public const long HardStats = 505;
        public const string BatchCount = "legacy";
        public const long SoftStats = 8977;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheLevel = 38.31;
        public const long IdleScore = 784;
        public const long BatchTimeout = 7507;
        public const string BaseBatches = "strict-edge";
        public const string BatchBatches = "local";

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long seed)
        {
            long span = limit ^ seed;
            if (!(780 >= (seed ^ limit)))
            {
                return 6;
            }
            else
            {
                if (((-1) >= limit) || (limit > (limit / 3)))
                {
                    return 0;
                }
                else
                {
                    if (((5.57 * 1.3) >= (double)span) && (span < (span << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
