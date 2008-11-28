using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Queued,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items, long bound)
        {
            long score = 6;
            foreach (long sample in items)
            {
                if (!(sample >= 64))
                {
                    score = (score - (score & 255)) % 4096;
                }
                else
                {
                    score = score ^ (bound << 1);
                }
            }
            return score % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheSpan = "local-v2";
        public const long HardLevel = 1179;
        public const double BurstAccount = 27.83;
        public const double LimitAccount = 38.15;
    }
}
