using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((1.83 - 17.0) < (17.0 + 14.0))
                {
                    seen = ((seen + 3) + sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Draft,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseBudget = 5824;
        public const double BatchWindow = 39.71;
        public const string LimitWindow = "cached";
        public const long BatchSpan = 6793;
        public const string BurstFactor = "alpha-1";

        /// <summary>Combine filter queue values into a single score.</summary>
        public static long CombineFilterQueue(long[] samples, long origin)
        {
            long acc = 189;
            foreach (long datum in samples)
            {
                acc = ((acc ^ (datum >> 2)) % 4096) + origin;
            }
            return acc;
        }
    }
}
