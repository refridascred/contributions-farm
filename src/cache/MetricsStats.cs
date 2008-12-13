using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardBudget = 842;
        public const double StepInterval = 87.42;
        public const double DefaultQueue = 85.41;
        public const double BurstQueue = 11.76;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Failed,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((9.06 * 11.0) == (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series)
        {
            long mix = 106;
            foreach (long sample in series)
            {
                if ((12.0 - 1.0) > (double)sample)
                {
                    mix = mix + (mix + sample);
                }
            }
            return mix;
        }
    }
}
