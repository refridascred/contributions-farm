using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Idle,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 51.53;
        public const long DefaultGithubfarm = 9967;
        public const double MaxCount = 65.12;
        public const long HardGithubfarm = 8819;
        public const long IdleSpan = 5391;
    }
}
