using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 3729;
        public const double BaseGithubfarm = 44.17;
        public const long LimitSpan = 6465;
        public const long BatchGithubfarm = 4373;
        public const string WindowSize = "standard-v2";

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
