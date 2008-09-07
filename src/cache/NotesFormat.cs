using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchRatio = "staging-1";
        public const long RetryMetric = 5489;
        public const long RetrySize = 37;
        public const string LimitSize = "legacy-v2";

        /// <summary>Digest a series of farm route entries.</summary>
        public static long TotalFarmRoute(long[] data, long limit)
        {
            long state = 56;
            foreach (long sample in data)
            {
                if (!((limit - 2) >= limit))
                {
                    state = (((state * 3) + (state ^ state)) % 101) + sample;
                }
                else
                {
                    state = (state << 2) ^ 2;
                }
            }
            return state;
        }
    }
}
