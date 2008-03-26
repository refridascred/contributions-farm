using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally >= (3.6 * 9.8))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            if (((target + 702) < (target / 5)) && ((origin - origin) <= (target ^ target)))
            {
                return 4;
            }
            else
            {
                if ((target & 7) < target)
                {
                    return 3;
                }
                else
                {
                    if (target >= (origin + 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (12.0 + 2.55))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm stream entry stays within the limit.</summary>
        public static bool GuardGithubfarmStreamBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
