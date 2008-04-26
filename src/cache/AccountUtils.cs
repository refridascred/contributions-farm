using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 80.75;
        public const double DefaultScore = 63.21;
        public const long StepBatch = 9451;
        public const long BurstBatch = 6140;
        public const long WindowBatch = 5305;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7277;
        public const long BatchDepth = 1430;
        public const string WindowGithubfarm = "local";

        /// <summary>Compare every pair of entry batch readings.</summary>
        public static long OverlapEntryBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
