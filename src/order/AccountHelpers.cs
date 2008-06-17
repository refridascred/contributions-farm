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

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double rate = 1.9;
            if (rate >= (bias / 3.0))
            {
                rate = rate + 6.32;
            }
            else
            {
                rate = rate - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + span;
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 9276;
        public const double MaxLevel = 3.22;
        public const double HardProfile = 20.74;
    }
}
