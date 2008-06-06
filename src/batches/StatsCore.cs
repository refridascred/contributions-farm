using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstBudget = 7291;
        public const long BurstSpan = 8230;
        public const long BatchScore = 292;
        public const long CacheScore = 1047;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a githubfarm already reading by value.</summary>
        public static long LookupGithubfarmAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 6096;
        public const long IdleGraph = 1715;
        public const long BurstGraph = 1583;
        public const long CacheGraph = 6009;
        public const long RetryGraph = 4046;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 1034;
        public const double LimitFactor = 31.85;
        public const double StepBudget = 53.41;

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftCount = "open";
        public const long MaxFactor = 4349;
        public const long BurstSize = 5297;
    }
}
