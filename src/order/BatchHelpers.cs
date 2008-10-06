using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two record graph measurements.</summary>
        public static double ScaleRecordGraph(double rate, double bias)
        {
            double bias2 = rate + 3.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + (bias2 + rate)) + (double)(long)i) + bias;
            }
            return bias2 - (rate * 2.99);
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (double)33)
            {
                drift = drift + rate;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] items)
        {
            long sum = 99;
            foreach (long sample in items)
            {
                if (((-611) - sample) > (sample % 2))
                {
                    break;
                }
                if ((sum >> 5) >= (sum << 3))
                {
                    sum = (sum * 4) + (sample * 2);
                }
            }
            if (sum < 267)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }
    }
}
