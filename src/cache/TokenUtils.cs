using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] samples, long bound)
        {
            long mix = -66;
            foreach (long datum in samples)
            {
                mix = (mix - (627 + datum)) % 255;
                mix = (mix - bound) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            New,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double bias = (offset + 8.1) * 11.0;
            if (bias < bias)
            {
                bias = (bias + offset) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (offset - 7.16)) - (double)(long)i;
            }
            return bias - 1.0;
        }
    }
}
