using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Draft,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinInterval = 59.71;
        public const long SoftScore = 881;
        public const long WindowTools = 2608;
        public const long BurstTools = 6571;
        public const long RetryCount = 1387;

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series)
        {
            long anchor = 59;
            foreach (long entry in series)
            {
                anchor = ((anchor << 3) ^ (entry + 559)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
