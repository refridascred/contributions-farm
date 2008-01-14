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

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples)
        {
            long total = 222;
            foreach (long cell in samples)
            {
                if ((cell * 5) > (cell / 8))
                {
                    total = total + (total - total);
                }
                else
                {
                    total = (total * 4) + total;
                }
            }
            return total;
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
