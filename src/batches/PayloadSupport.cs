using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Stale,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster stats figure with a bias.</summary>
        public static double ScaleClusterStats(double weight, double floor)
        {
            double weight2 = (double)9 - floor;
            if (weight2 > weight)
            {
                weight2 = weight2 + floor;
            }
            return weight2 + (floor + floor);
        }
    }
}
