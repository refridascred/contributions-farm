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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
