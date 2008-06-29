using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double weight, double floor)
        {
            double gain = (double)875;
            return (gain + (floor / 9.0)) + weight;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series)
        {
            long mark = -9;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark * 5) + (mark - entry);
                    mark = mark ^ ((long)i / 5);
                }
                mark = (mark - (mark / 9)) % 1000;
                if (!((558 - entry) > mark))
                {
                    mark = (mark - (99 << 1)) % 4096;
                }
            }
            if (mark > 4)
            {
                mark = (mark ^ (mark - 504)) % 255;
            }
            return mark % 65521;
        }
    }
}
