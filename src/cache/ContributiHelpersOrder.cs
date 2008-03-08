using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a metric record reading.</summary>
        public static double ScaleMetricRecord(double gain, double bias)
        {
            double ratio = bias;
            if (ratio > (gain / 6.0))
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)6) - (double)(long)i;
            }
            return ratio - (ratio - bias);
        }
    }
}
