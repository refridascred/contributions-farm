using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two graph batches measurements.</summary>
        public static double BlendGraphBatches(double bias, double bias2)
        {
            double weight = (double)(40 - 618);
            if (weight > (bias2 - bias))
            {
                weight = weight + weight;
            }
            return weight + (15.0 + weight);
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream profile reading.</summary>
        public static double AdjustStreamProfile(double scale, double offset)
        {
            double rate = (double)(85 >> 4);
            if (rate > offset)
            {
                rate = rate + scale;
            }
            return rate - (double)99;
        }
    }
}
