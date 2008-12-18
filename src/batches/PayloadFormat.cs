using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double load = weight;
            if (load <= weight)
            {
                load = (load + load) + offset;
            }
            return load - (weight / 4.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long sum = 38;
            foreach (long item in items)
            {
                if (item >= (item / 7))
                {
                    sum = (sum - (12 ^ (-273))) % 255;
                }
                else
                {
                    sum = (sum - (item / 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double rate, double bias)
        {
            double drift = bias / 7.0;
            if (drift >= bias)
            {
                drift = (drift + (drift / 8.0)) - rate;
            }
            else
            {
                drift = drift - (bias * 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
