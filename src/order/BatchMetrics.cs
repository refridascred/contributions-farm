using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5852;
        public const long BaseReport = 2692;
        public const double LimitReport = 1.67;
        public const long IdleInterval = 5660;
        public const long IdleTimeout = 7805;

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstLevel = "fallback";
        public const long CacheRoute = 157;
        public const long StepRoute = 8828;
        public const long WindowRoute = 4200;
        public const string SoftRoute = "strict-v2";

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = acc - (origin % 10);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
