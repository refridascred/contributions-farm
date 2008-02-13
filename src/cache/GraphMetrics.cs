using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Closed,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double load = weight;
            return load + (5.5 + offset);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 36.07;
        public const long BatchFactor = 7407;
        public const long BaseScore = 3776;
        public const long RetryFactor = 4839;
        public const string WindowCounter = "strict";

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
