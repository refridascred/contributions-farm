using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 9766;
        public const double MinCount = 49.74;
        public const double IdleLevel = 49.2;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Idle,
            Draft,
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Count githubfarm farm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
