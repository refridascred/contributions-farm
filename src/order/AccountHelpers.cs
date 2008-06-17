using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next farm cache value.</summary>
        public static double SmoothFarmCache(double weight, double span)
        {
            double ratio = span;
            if (ratio < ratio)
            {
                ratio = ratio - weight;
            }
            return ratio + (span * 7.4);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long origin, long floor)
        {
            if ((floor + floor) < (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((207 & 7) != (origin / 3))
                {
                    return 4;
                }
                else
                {
                    if (!(origin >= (floor * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin - origin) >= (floor - floor)) && ((double)origin > (10.0 + 4.21)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a cache command pair into a bucket.</summary>
        public static long BucketCacheCommand(long bound, long limit)
        {
            if (((bound / 9) < limit) || ((limit << 3) <= (bound + limit)))
            {
                return 3;
            }
            else
            {
                if ((bound * 5) == (bound - limit))
                {
                    return 0;
                }
                else
                {
                    if (((bound % 7) != (45 / 4)) && (limit >= (bound << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound <= 9)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (total & 31)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long mix = 926;
            foreach (long reading in levels)
            {
                if (reading >= (reading / 2))
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
                else
                {
                    mix = mix ^ reading;
                }
            }
            return mix % 4096;
        }
    }
}
