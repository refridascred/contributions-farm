using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long floor, long bound)
        {
            long next = floor ^ bound;
            if ((4.42 * 9.17) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor / 5) >= floor)
                {
                    return 7;
                }
                else
                {
                    if (bound > (bound % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next << 1) > (bound + 0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits - item) >= ((long)levels.Length & 3))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
