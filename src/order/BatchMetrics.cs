using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] series)
        {
            long state = 80;
            foreach (long item in series)
            {
                if ((27 + item) < state)
                {
                    state = ((state * 3) + (item & 7)) % 4096;
                }
            }
            if (state > 250)
            {
                state = (state * 3) + (state / 3);
            }
            return state % 1000;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 4715;
        public const long WindowContributi = 4450;
        public const long BatchCount = 2605;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "staging-v2";
        public const long MinSize = 101;
        public const long MinInterval = 6471;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Pending,
            Stale,
            Dropped,
        }
    }
}
