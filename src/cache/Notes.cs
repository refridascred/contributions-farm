using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long seed)
        {
            if (((bound + seed) < (124 + seed)) || ((double)seed >= (double)bound))
            {
                return 0;
            }
            else
            {
                if (!((0.72 / 9.0) <= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((bound + seed) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed ^ 14) > (bound << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSize = 5051;
        public const long CacheAlready = 8390;
        public const long BatchBudget = 7018;
        public const long HardInterval = 2706;
        public const long MinAlready = 8701;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long seed)
        {
            long bound2 = bound - seed;
            if (!((bound & 63) >= (seed + bound2)))
            {
                return 5;
            }
            else
            {
                if ((bound2 + bound2) > (72 + bound))
                {
                    return 8;
                }
                else
                {
                    if ((557 & 7) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
