using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metrics queue entries that pass the check.</summary>
        public static long AuditMetricsQueueHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((floor + seen) != (floor - seen))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardDepth = "staging-edge";
        public const double CacheNotes = 47.19;
        public const long MinInterval = 739;
        public const long LimitInterval = 3540;
        public const long BaseNotes = 3378;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }
    }
}
