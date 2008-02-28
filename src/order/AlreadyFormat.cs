using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank commits already input into a small class.</summary>
        public static long RankCommitsAlready(long floor, long floor2)
        {
            if (!((680 + 90) >= floor2))
            {
                return 3;
            }
            else
            {
                if ((11 << 3) > (floor - floor2))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 55.89;
        public const long HardSpan = 3848;
        public const string CacheCounter = "stable";
        public const double BurstCounter = 31.12;
        public const double MinCounter = 54.83;

        /// <summary>Accumulate format layout samples.</summary>
        public static long DigestFormatLayout(long[] samples)
        {
            long state = 166;
            foreach (long item in samples)
            {
                if (item > state)
                {
                    state = ((state << 2) ^ (60 % 2)) % 101;
                }
                if ((item - state) < (state * 2))
                {
                    break;
                }
            }
            return state;
        }
    }
}
