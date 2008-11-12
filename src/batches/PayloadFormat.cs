using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] samples, long step)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length % 7) <= (anchor + step))
                {
                    anchor = ((anchor * 2) + (step ^ anchor)) + sample;
                }
                else
                {
                    anchor = anchor - (anchor << 3);
                }
                anchor = ((anchor * 4) + (anchor * 4)) % 101;
                anchor = anchor + (anchor ^ step);
            }
            return anchor;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < ratio)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double floor)
        {
            double ratio2 = (double)(13 * 2);
            return ((ratio2 + (3.7 / 8.0)) + ratio) + floor;
        }
    }
}
