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

        /// <summary>Derive the next order contributi value from a seed.</summary>
        public static long SeriesOrderContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = mix ^ offset;
                mix = ((mix << 3) ^ (offset >> 1)) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
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
