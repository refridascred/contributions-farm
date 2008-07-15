using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long origin)
        {
            long prev = offset - origin;
            if ((offset * 5) < 81)
            {
                return 1;
            }
            else
            {
                if ((prev - origin) == (origin + offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) == (entry + 65))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples)
        {
            long anchor = -87;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 3) + (anchor % 12)) ^ sample;
            }
            if (anchor > (-89))
            {
                anchor = (anchor ^ (anchor * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSpan = 2304;
        public const long StepEditor = 3941;
        public const long SoftEditor = 2749;
    }
}
