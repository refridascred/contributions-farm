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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
