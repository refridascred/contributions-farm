using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double floor)
        {
            double bias = (double)(38 ^ 8);
            if (bias <= (double)(-59))
            {
                bias = (bias + ratio) + floor;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias - bias;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double rate = bias;
            if (rate < bias)
            {
                rate = rate - (gain / 8.0);
            }
            else
            {
                rate = rate - (6.6 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (bias / 4.0)) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}
