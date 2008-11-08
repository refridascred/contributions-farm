using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long step, long step2)
        {
            long step3 = step ^ step2;
            if (1.4 <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((step + step2) > (step ^ step3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((seed % 64) == (matches & 31))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + entry) != (entry - entry))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long mark = 22;
            foreach (long value in series)
            {
                if ((double)value <= 7.44)
                {
                    mark = mark ^ 6;
                }
                else
                {
                    mark = (mark ^ (value + mark)) % 97;
                }
            }
            if (mark > 0)
            {
                mark = (mark - (mark - mark)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long target, long bound)
        {
            if ((double)bound >= 17.0)
            {
                return 2;
            }
            else
            {
                if (target < (target << 3))
                {
                    return 7;
                }
                else
                {
                    if (((9.37 - 19.0) >= (double)bound) && ((target % 2) > bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + (-3)) <= bound) && (78 >= (bound / 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long seed, long origin)
        {
            if ((double)origin < (2.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if ((3.0 * 5.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (seed <= (seed / 4))
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
    }
}
