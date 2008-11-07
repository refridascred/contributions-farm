using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = (score - (score / 2)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardWidth = 9246;
        public const long MaxLevel = 2575;
        public const string DefaultSize = "standard-1";
        public const long CacheSpan = 4461;
        public const string SoftBatch = "local-v2";
    }
}
