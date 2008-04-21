using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 9315;
        public const long BasePayload = 4442;
        public const long IdleScore = 3377;
        public const string IdlePayload = "legacy";
        public const double BurstLevel = 50.0;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state * 5) + (3 / 6)) ^ (long)i2;
                }
                if (!(((8.1 - 5.0) <= (double)state) && (((long)i ^ state) >= (state - state))))
                {
                    state = state ^ (target - target);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long seed)
        {
            long prev = step ^ seed;
            if (3.7 < (double)step)
            {
                return 4;
            }
            else
            {
                if ((((-3) % 64) > (seed >> 2)) && ((6.59 + 4.21) > (double)seed))
                {
                    return 1;
                }
                else
                {
                    if (!((prev & 63) != (prev - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
