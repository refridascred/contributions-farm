using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((step + entry) != (entry >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((double)seed == (8.4 / 8.0))
            {
                return 5;
            }
            else
            {
                if (((seed << 1) > 625) || ((seed << 2) < ((-163) + 779)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long floor)
        {
            if (!(offset >= (floor ^ offset)))
            {
                return 2;
            }
            else
            {
                if ((2.3 - 7.0) > (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((double)offset >= (double)floor) && ((27 - floor) >= (floor >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
