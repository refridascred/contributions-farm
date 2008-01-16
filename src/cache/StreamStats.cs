using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a already route value against two limits.</summary>
        public static long GradeAlreadyRoute(long seed, long step)
        {
            long span = seed + step;
            if (((span << 1) != (seed % 24)) && ((1.75 - 18.0) < (double)seed))
            {
                return 4;
            }
            else
            {
                if ((step % 12) <= 83)
                {
                    return 1;
                }
                else
                {
                    if ((seed - step) == ((-78) & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next farm route value from a seed.</summary>
        public static long RollFarmRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - (origin + origin)) % 4096;
                if (mix >= ((long)i * 5))
                {
                    mix = mix + (5 * 2);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 7855;
        public const long BatchStats = 879;
        public const long WindowInterval = 7356;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Done,
            Failed,
            Idle,
            Queued,
        }
    }
}
