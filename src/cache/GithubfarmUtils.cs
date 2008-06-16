using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 2903;
        public const long HardOrder = 8701;
        public const string RetryOrder = "legacy-1";
        public const long BurstRatio = 3941;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values, long offset)
        {
            long total = 980;
            foreach (long cell in values)
            {
                if ((double)offset >= (double)total)
                {
                    total = total ^ (cell >> 3);
                }
            }
            return total % 97;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Retry,
            Locked,
        }
    }
}
