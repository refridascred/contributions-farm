using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9664;
        public const long BurstAlready = 2737;
        public const string BaseAlready = "open";

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Stale,
            Draft,
        }
    }
}
