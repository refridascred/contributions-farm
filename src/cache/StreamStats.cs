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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 3) + (anchor & 127);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 7855;
        public const long BatchStats = 879;
        public const long WindowInterval = 7356;

        /// <summary>Derive the next format already value from a seed.</summary>
        public static long IterateFormatAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
