using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Synced,
            Dropped,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 2;
        public const long StepReport = 6261;
        public const long WindowFactor = 1760;
        public const long SoftReport = 1029;
        public const double StepInterval = 77.46;
    }
}
