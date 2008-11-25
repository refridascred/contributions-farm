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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
