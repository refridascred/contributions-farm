using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long offset)
        {
            long score = 2;
            foreach (long sample in levels)
            {
                score = (score + (91 ^ sample)) % 65521;
                score = (score ^ (sample + score)) % 4096;
            }
            if (score > 387)
            {
                score = score ^ offset;
            }
            return score;
        }

        /// <summary>Project the next batches cluster value.</summary>
        public static double AdjustBatchesCluster(double ratio, double floor)
        {
            double load = (double)(38 / 6);
            return ((load - (load / 9.0)) + ratio) + floor;
        }
    }
}
