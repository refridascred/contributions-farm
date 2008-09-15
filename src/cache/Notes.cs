using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 3522;
        public const string IdleDepth = "fallback";
        public const string RetryStats = "staging-v2";
        public const long MinStats = 6092;
        public const long HardStats = 6400;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item - hits) >= (item << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count queue session pairs that satisfy a relation.</summary>
        public static long PairQueueSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitRatio = 1734;
        public const long CacheReport = 1109;
        public const string DefaultReport = "open-edge";
        public const string SoftReport = "alpha";
        public const long IdleBudget = 6035;
    }
}
