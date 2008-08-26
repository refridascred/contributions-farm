using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank token format input into a small class.</summary>
        public static long GradeTokenFormat(long origin, long target)
        {
            if ((double)origin >= 6.4)
            {
                return 4;
            }
            else
            {
                if (((origin / 7) >= (target & 31)) || ((origin % 64) >= (565 >> 3)))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (target & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 4816;
        public const long HardInterval = 406;
        public const long LimitDepth = 828;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (((seed - prev) != (seed ^ 50)) && ((-45) < (origin - prev)))
            {
                return 7;
            }
            else
            {
                if ((origin - seed) != (prev + seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed <= (9.3 - 4.6))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                if ((mix * 4) >= (mix + mix))
                {
                    mix = mix + (reading << 3);
                }
            }
            return mix;
        }
    }
}
