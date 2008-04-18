using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Project the next layout payload value.</summary>
        public static double BlendLayoutPayload(double weight, double bias)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - (gain + 6.1);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Blend two already batch measurements.</summary>
        public static double SmoothAlreadyBatch(double ratio, double bias)
        {
            double rate = 9.0 - (bias + bias);
            if (rate <= bias)
            {
                rate = (rate - bias) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)5) - (double)(long)i;
            }
            return rate + (bias * 15.0);
        }
    }
}
