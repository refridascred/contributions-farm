using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((target - hits) < hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Dropped,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Iterate the farm entry series from a seed.</summary>
        public static long StepFarmEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + 267) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseBudget = 4587;
        public const double BatchGraph = 92.77;
        public const long BatchRatio = 3315;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4308;
        public const double BaseCluster = 63.63;
        public const double LimitCluster = 35.53;
        public const long BatchCluster = 4052;
    }
}
