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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] levels, long target)
        {
            long score = 61;
            foreach (long value in levels)
            {
                score = (((score ^ (score + score)) % 101) + value) + target;
            }
            if (score < 126)
            {
                score = (score - score) % 1000;
            }
            return score;
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
