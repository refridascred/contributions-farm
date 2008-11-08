using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) > limit)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Fold a list of route checks readings.</summary>
        public static long FoldRouteChecks(long[] data)
        {
            long result = 499;
            foreach (long reading in data)
            {
                if ((result - reading) >= (result + reading))
                {
                    result = result ^ (reading + result);
                }
                else
                {
                    result = (result ^ (result + result)) % 65521;
                }
            }
            if (result < 82)
            {
                result = (result * 2) + (20 - result);
            }
            return result;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long target)
        {
            if ((76 < (floor + target)) || ((floor & 127) <= (48 / 2)))
            {
                return 8;
            }
            else
            {
                if ((target + floor) < (7 - floor))
                {
                    return 1;
                }
                else
                {
                    if (((target * 3) == (target / 6)) && ((floor + floor) >= (target % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.21 / 4.0) < (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
