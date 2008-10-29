using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Active,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the commits farm entries that pass the check.</summary>
        public static long CountCommitsFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((double)hits == (8.5 + 14.0)) || ((hits % 60) >= reading)) && !(hits > reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxDepth = 45.45;
        public const double IdleFactor = 30.14;
        public const long MaxInterval = 2758;
        public const double MinBudget = 98.01;
        public const long SoftChannel = 7688;
    }
}
