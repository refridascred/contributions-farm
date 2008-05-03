using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many batches cluster samples are out of range.</summary>
        public static long AuditBatchesClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) > (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryBudget = 34.36;
        public const double CacheScore = 97.45;
        public const string MinFactor = "alpha";
    }
}
