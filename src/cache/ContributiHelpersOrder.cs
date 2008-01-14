using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a profile channel figure with a bias.</summary>
        public static double BlendProfileChannel(double bias, double bias2)
        {
            double rate = bias2;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (5.19 + bias)) - (double)(long)i;
            }
            return rate + (bias * 4.0);
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long offset)
        {
            long diff = bound + offset;
            if ((double)offset == (3.65 - 3.0))
            {
                return 4;
            }
            else
            {
                if ((8.48 * 18.0) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 4) < (diff - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long bound, long seed)
        {
            if ((seed + seed) >= seed)
            {
                return 6;
            }
            else
            {
                if ((6.5 + 7.47) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
