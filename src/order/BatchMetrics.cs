using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (double)52)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Paused,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
