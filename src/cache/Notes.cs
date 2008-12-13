using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits <= (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 4723;
        public const long WindowFactor = 813;
        public const string CacheStats = "standard-v2";
        public const long DefaultBudget = 7704;
        public const string RetryScore = "staging-v2";
    }
}
