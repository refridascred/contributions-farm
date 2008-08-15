using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a farm queue figure with a bias.</summary>
        public static double AdjustFarmQueue(double weight, double floor)
        {
            double mean = 2.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (double)521) + (double)(long)i) - floor;
            }
            return mean - weight;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Done,
            Synced,
            Locked,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
