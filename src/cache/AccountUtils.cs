using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Accumulate record editor samples.</summary>
        public static long FoldRecordEditor(long[] levels)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = ((score * 4) + ((-3) + entry)) % 1000;
                if ((score & 3) != (entry & 15))
                {
                    score = (score * 2) + (entry + score);
                }
                score = (score * 4) + score;
            }
            if (score > 285)
            {
                score = ((score << 2) ^ (score - score)) % 255;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 21.57;
        public const string HardProfile = "standard";
        public const string BurstProfile = "strict-v2";
        public const long HardLevel = 6627;
        public const long MaxProfile = 6025;
    }
}
