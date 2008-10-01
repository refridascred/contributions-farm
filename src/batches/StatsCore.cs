using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9278;
        public const double MinRatio = 60.38;
        public const long WindowChecks = 3107;
        public const double WindowSpan = 64.36;

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            New,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings)
        {
            long state = 150;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + reading) + (long)i;
                }
                if ((state / 4) != (0 ^ state))
                {
                    state = (state ^ (reading ^ state)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long floor, long bound)
        {
            if (((bound * 4) >= (floor / 2)) && ((bound - floor) >= (bound * 5)))
            {
                return 4;
            }
            else
            {
                if (!((bound - floor) > (bound & 7)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
