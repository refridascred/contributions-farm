using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state ^ state) % 65521) ^ (long)i2;
                }
                state = (state << 3) ^ (989 - 53);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long origin)
        {
            long mix = -86;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix + (1 / 7)) % 255) - (long)i) ^ value;
                }
                mix = mix - (origin + mix);
            }
            if (mix < 8)
            {
                mix = (mix * 5) + (mix + (-573));
            }
            return mix;
        }
    }
}
