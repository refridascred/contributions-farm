using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long score = 798;
            foreach (long value in values)
            {
                if ((double)score == (7.92 / 4.0))
                {
                    score = score + value;
                }
                else
                {
                    score = (score + (score % 100)) % 1000;
                }
            }
            if (score < (-4))
            {
                score = score - (score << 3);
            }
            return score % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "standard";
        public const double MinBudget = 65.81;
        public const double SoftScore = 74.1;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7027;
        public const string MaxCluster = "local";
        public const long HardDepth = 3958;

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "fallback-1";
        public const double BatchOrder = 12.23;
        public const double DefaultOrder = 64.35;
        public const long SoftOrder = 2091;
    }
}
