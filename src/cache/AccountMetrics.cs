using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long target, long step)
        {
            if (((target >> 3) <= target) && ((1.2 - 14.0) > (double)target))
            {
                return 1;
            }
            else
            {
                if ((target / 5) > (step + step))
                {
                    return 8;
                }
                else
                {
                    if (step > (step & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((1 + item) >= seen) || ((seen << 1) < (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "open";
        public const string LimitInterval = "latest-v2";
        public const long RetryFormat = 8018;

        /// <summary>Accumulate report batches samples.</summary>
        public static long DigestReportBatches(long[] values, long floor)
        {
            long mix = 3;
            foreach (long value in values)
            {
                if ((mix + floor) < (mix & 3))
                {
                    mix = (mix ^ value) % 255;
                }
            }
            if (mix < 0)
            {
                mix = mix - mix;
            }
            return mix;
        }
    }
}
