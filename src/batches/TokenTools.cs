using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Queued,
            Idle,
            Active,
            Done,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7170;
        public const long SoftGithubfarm = 6454;
        public const string IdleGithubfarm = "legacy-v2";
    }
}
