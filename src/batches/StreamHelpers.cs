using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((step + step) > item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "primary";
        public const long BatchCommits = 6043;
        public const long MaxCommits = 7269;

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long target2)
        {
            long offset = target + target2;
            if (!((target % 5) >= target))
            {
                return 0;
            }
            else
            {
                if ((target + target2) > (910 % 5))
                {
                    return 6;
                }
                else
                {
                    if ((target >> 5) >= (offset / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target != (0.5 * 5.84))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
