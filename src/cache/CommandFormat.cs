using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((double)item == (3.0 / 6.0)) && ((6.18 - 3.65) == (double)hits))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample + hits) <= hits) && (offset < (5 + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long origin)
        {
            long bound = seed - origin;
            if (((double)origin <= (9.27 - 1.0)) && ((10.0 - 7.53) != (double)bound))
            {
                return 2;
            }
            else
            {
                if ((1.55 + 6.0) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((899 >> 5) == (origin + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound >= (origin ^ bound))
                        {
                            return 3;
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
}
