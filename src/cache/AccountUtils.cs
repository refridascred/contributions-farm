using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 49.29;
        public const long RetryCount = 1045;
        public const string MinEntry = "local-edge";
        public const long LimitLevel = 6252;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally < (0 - step))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 5754;
        public const string RetryDepth = "local-v2";
        public const long BurstScore = 9295;
        public const long IdleBatches = 8457;
        public const string SoftBatches = "legacy-1";
    }
}
