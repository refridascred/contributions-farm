using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCount = 9043;
        public const double RetryFactor = 41.81;
        public const long BurstFactor = 4503;
        public const long CacheScore = 6724;
        public const string WindowCommits = "stable";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((11.0 <= (double)target) || ((hits - hits) < target)) || (target > item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
