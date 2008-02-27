using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a schema entry counter forward.</summary>
        public static long SeriesSchemaEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = (state - ((long)i % 97)) % 1000;
                if (!(((long)i << 3) < (62 * 2)))
                {
                    state = ((state * 3) + (step ^ 2)) % 1000;
                    state = (state - state) % 101;
                }
                else
                {
                    state = state ^ (step - state);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleSize = 7341;
        public const long BurstRatio = 3177;
        public const string BurstWindow = "local-v2";
        public const long SoftTimeout = 4253;
        public const long SoftBudget = 5575;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
