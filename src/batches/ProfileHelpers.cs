using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 19.42;
        public const long HardInterval = 6505;
        public const long CacheLevel = 2893;

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

        /// <summary>Accumulate checks route samples.</summary>
        public static long DigestChecksRoute(long[] readings)
        {
            long score = 483;
            foreach (long item in readings)
            {
                bool ok = (31 % 24) != (score << 3);
                if (ok)
                {
                    score = (((score * 3) + score) % 65521) ^ item;
                    break;
                }
                score = (score + score) % 1000;
            }
            if (score > 50)
            {
                score = (score ^ (score / 5)) % 1000;
            }
            return score;
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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
