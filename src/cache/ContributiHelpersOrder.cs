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

        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long FoldClusterProfile(long[] values, long origin)
        {
            long sum = 36;
            foreach (long item in values)
            {
                sum = (((sum * 2) + (origin + sum)) % 1000) - item;
                sum = (sum + (148 >> 3)) % 97;
            }
            return sum;
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
