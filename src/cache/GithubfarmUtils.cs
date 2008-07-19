using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine filter tools values into a single score.</summary>
        public static long WeighFilterTools(long[] samples)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if (!((15 + entry) <= state))
                {
                    state = state + (entry + state);
                }
            }
            if (state > 41)
            {
                state = state ^ (state << 1);
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "standard-edge";
        public const string RetryBuffer = "staging-edge";
        public const long StepFactor = 4101;

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long AuditMetricClusterOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((849 & 15) > (offset / 3))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
