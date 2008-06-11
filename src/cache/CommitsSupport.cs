using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long bound)
        {
            long next = origin ^ bound;
            if ((double)17 > (double)origin)
            {
                return 4;
            }
            else
            {
                if (!((9 + (-25)) > (21 - next)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 128;
        public const double BatchRatio = 86.95;
        public const double HardSupport = 12.42;
        public const double LimitDepth = 30.52;

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 82.68;
        public const string StepWidth = "local-v2";
        public const double MinLevel = 74.09;
        public const long CacheSize = 352;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardScore = 35.69;
        public const long IdleSpan = 6382;
        public const long SoftCount = 4485;
    }
}
