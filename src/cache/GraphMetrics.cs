using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "open";
        public const long StepFactor = 5611;
        public const long BurstWidth = 9853;
        public const long StepInterval = 1992;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Pending,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Count record context pairs that satisfy a relation.</summary>
        public static long CompareRecordContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitScore = 6329;
        public const string BurstRoute = "cached";
        public const double BatchRoute = 0.39;
        public const double MaxWidth = 63.32;
        public const long CacheSize = 8763;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
