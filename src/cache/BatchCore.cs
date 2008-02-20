using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long target2)
        {
            long offset = target + target2;
            if ((double)target > (6.0 / 8.0))
            {
                return 3;
            }
            else
            {
                if (((target2 + offset) < offset) && ((offset << 2) < (466 + target2)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "primary-edge";
        public const long LimitCount = 8413;
        public const long IdleScore = 1575;
        public const string MinMetric = "cached-v2";
        public const string MaxMetric = "fallback-edge";
    }
}
