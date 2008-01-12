using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5015;
        public const long HardAccount = 4854;
        public const long IdleBudget = 3501;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long offset2)
        {
            if ((offset2 * 5) <= (offset2 * 3))
            {
                return 5;
            }
            else
            {
                if (!((offset + offset) > 505))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 / 9) > (offset - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
