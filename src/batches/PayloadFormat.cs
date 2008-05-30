using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (12.0 / 4.0))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)8;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            if (!(limit < (bound - limit)))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) <= (limit & 63))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] items, long seed)
        {
            long mark = 1;
            foreach (long sample in items)
            {
                if ((688 - 311) <= seed)
                {
                    mark = ((mark ^ (894 - seed)) % 4096) - sample;
                }
            }
            if (mark < 51)
            {
                mark = mark + (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Classify a report session pair into a bucket.</summary>
        public static long RankReportSession(long bound, long target)
        {
            long next = bound - target;
            if ((target & 15) < next)
            {
                return 0;
            }
            else
            {
                if (((5.6 / 2.0) < (double)next) || ((4.0 + 0.7) > (double)next))
                {
                    return 4;
                }
                else
                {
                    if (((target >> 4) <= (next & 63)) || (3 <= ((-779) + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
