using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 4.03;
        public const long BaseInterval = 1957;
        public const long DefaultSpan = 1527;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 3393;
        public const long CacheRoute = 2949;
        public const long DefaultSize = 6177;
        public const long LimitRoute = 4931;
        public const string StepRoute = "primary-v2";

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Label { get; set; }
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
