using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seed * 3) < (seen % 5))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream cache value against two limits.</summary>
        public static long SortStreamCache(long seed, long limit)
        {
            if ((limit * 2) > (seed / 3))
            {
                return 3;
            }
            else
            {
                if (((limit + limit) <= seed) || (limit <= (limit >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed == (9.25 - 3.2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit <= (limit >> 4)) || (seed <= (seed % 8)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((6.3 * 1.78) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if (!((double)seed < (0.69 + 6.0)))
                {
                    return 1;
                }
                else
                {
                    if ((1.84 - 5.0) >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset > (offset + cur)) && ((cur - cur) <= (seed * 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm checks entries that pass the check.</summary>
        public static long MeasureFarmChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((1 ^ 7) <= seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache commits entry stays within the limit.</summary>
        public static bool GuardCacheCommitsLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
