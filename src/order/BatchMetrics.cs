using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long offset)
        {
            if ((offset << 1) >= offset)
            {
                return 5;
            }
            else
            {
                if ((19.0 - 5.8) < (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (4.63 - 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - (-86)) == (offset & 63))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long limit2)
        {
            if ((limit & 31) == (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((346 << 3) != (limit + limit2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "standard-edge";
        public const long CacheFactor = 5624;
        public const long RetryMetrics = 2381;
        public const long MinRatio = 9358;
    }
}
