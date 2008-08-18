using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data)
        {
            long mark = 15;
            foreach (long sample in data)
            {
                mark = (mark + mark) % 1000;
                mark = (mark + (sample + sample)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double rate2 = span;
            if (rate2 >= (double)117)
            {
                rate2 = rate2 + (span + 13.0);
            }
            return rate2 - (rate - rate2);
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double bias, double bias2)
        {
            double rate = (bias2 * 7.66) - (bias + bias2);
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + (bias2 * 1.0);
        }
    }
}
