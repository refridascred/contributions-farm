using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long target, long bound)
        {
            if (!((453 - target) != (bound * 4)))
            {
                return 2;
            }
            else
            {
                if (bound < (bound + target))
                {
                    return 8;
                }
                else
                {
                    if ((2 + target) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= offset)
            {
                rate2 = rate2 + (double)1;
            }
            else
            {
                rate2 = rate2 + (3.28 + 8.2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (rate2 * 15.0)) + (double)(long)i;
            }
            return rate2 - (rate2 - rate);
        }
    }
}
