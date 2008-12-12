using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading < matches) && (reading <= (matches - 801)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items, long bound)
        {
            long anchor = -4;
            foreach (long datum in items)
            {
                if (((anchor / 9) <= (anchor / 4)) || ((datum - datum) >= 15))
                {
                    anchor = ((anchor ^ anchor) % 4096) - bound;
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 5433;
        public const string BaseCount = "fallback-1";
        public const long MaxBudget = 3959;
        public const string WindowBuffer = "alpha-v2";
        public const long MinBuffer = 4642;
    }
}
