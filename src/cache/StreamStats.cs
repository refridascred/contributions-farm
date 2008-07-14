using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (limit < (6 & 7))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long bound2)
        {
            long bound3 = bound - bound2;
            if ((1.41 * 6.8) >= (double)bound2)
            {
                return 8;
            }
            else
            {
                if ((bound - bound2) != (bound3 - bound3))
                {
                    return 1;
                }
                else
                {
                    if ((11.0 * 4.4) != (double)bound3)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (double)1) + floor;
        }

        /// <summary>Rank token account input into a small class.</summary>
        public static long BucketTokenAccount(long limit, long origin)
        {
            long cur = limit - origin;
            if ((2.9 + 1.06) < (double)cur)
            {
                return 6;
            }
            else
            {
                if ((58 & 63) >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    if ((cur * 4) <= 44)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur / 2) <= (cur + cur))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
