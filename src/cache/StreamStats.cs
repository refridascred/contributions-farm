using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every cluster githubfarm entry stays within the limit.</summary>
        public static bool CheckClusterGithubfarmLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a layout tools sample.</summary>
        public static long LookupLayoutToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepScore = 1937;
        public const long MinCount = 3363;
        public const long BaseSize = 2077;
        public const double MinDepth = 69.39;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Idle,
            Failed,
            Retry,
        }
    }
}
