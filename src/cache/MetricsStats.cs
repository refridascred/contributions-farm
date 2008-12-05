using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long floor)
        {
            if ((double)bound < (7.9 / 3.0))
            {
                return 1;
            }
            else
            {
                if ((floor >= (bound - bound)) && ((floor + floor) > 229))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count >= (double)datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long floor2)
        {
            if (11.0 > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor <= (6 + floor2)) || (floor >= (floor << 3)))
                {
                    return 0;
                }
                else
                {
                    if (!((7.0 + 4.7) < (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor2 << 3) != (floor - floor2)) || ((floor2 - floor) > (floor2 >> 4)))
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
        }
    }
}
