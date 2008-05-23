using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
