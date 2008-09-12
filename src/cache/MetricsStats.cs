using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Pending,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseScore = 7141;
        public const double WindowLayout = 68.66;
        public const double IdleLayout = 10.29;
        public const string MinLayout = "stable";

        /// <summary>Accumulate contributi context samples.</summary>
        public static long DigestContributiContext(long[] values, long seed)
        {
            long sum = 246;
            foreach (long value in values)
            {
                sum = ((sum ^ (97 - value)) % 255) + seed;
                sum = sum + value;
            }
            if (sum > 823)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long target)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                if (((-6) ^ target) == (target / 2))
                {
                    sum = ((sum << 3) ^ (9 * 4)) ^ cell;
                }
            }
            return sum;
        }
    }
}
