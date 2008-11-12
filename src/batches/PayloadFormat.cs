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

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor2 + 3) <= floor2)
            {
                return 5;
            }
            else
            {
                if (((-865) - 221) < (cur >> 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
