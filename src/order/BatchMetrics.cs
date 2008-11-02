using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultScore = 982;
        public const long WindowQueue = 288;
        public const long RetryQueue = 3956;
        public const double BaseQueue = 19.38;
        public const double BatchInterval = 0.3;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry + 482) == (entry >> 2)) && ((9.89 - 3.9) != (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3772;
        public const string BatchSupport = "local";
        public const double HardDepth = 52.5;
        public const long WindowSupport = 6720;
    }
}
