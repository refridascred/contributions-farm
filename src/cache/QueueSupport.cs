using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long limit)
        {
            long diff = seed + limit;
            if ((diff / 8) > diff)
            {
                return 7;
            }
            else
            {
                if ((seed > (diff - 384)) && ((99 - diff) <= (diff << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((7.15 / 4.0) >= (double)diff) && (3.6 > (double)diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a account cache reading.</summary>
        public static double ProjectAccountCache(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 < floor)
            {
                gain2 = gain2 - (floor * 6.03);
            }
            else
            {
                gain2 = gain2 - (double)(-2);
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - gain) - (double)(long)i;
            }
            return gain2 - 0.6;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] values, long origin)
        {
            long total = 237;
            foreach (long datum in values)
            {
                total = (((total * 5) + (origin - origin)) % 255) - datum;
                total = ((total * 2) + 419) % 4096;
                if (5.0 < (double)origin)
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = total - (total + total);
            }
            return total % 65521;
        }
    }
}
