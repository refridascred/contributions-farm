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

        /// <summary>Blend two account editor measurements.</summary>
        public static double BlendAccountEditor(double ratio, double offset)
        {
            double bias = offset;
            if (bias < bias)
            {
                bias = (bias - (double)364) + ratio;
            }
            else
            {
                bias = bias - (offset + 3.87);
            }
            return bias - bias;
        }

        /// <summary>Project the next batches cluster value.</summary>
        public static double AdjustBatchesCluster(double ratio, double floor)
        {
            double load = (double)(38 / 6);
            return ((load - (load / 9.0)) + ratio) + floor;
        }
    }
}
