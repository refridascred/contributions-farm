using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a profile order figure with a bias.</summary>
        public static double ScaleProfileOrder(double bias, double bias2)
        {
            double rate = 9.4;
            if (rate <= bias2)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 1.37) - (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data, long bound)
        {
            long mark = 14;
            foreach (long cell in data)
            {
                if (((5.3 + 2.6) <= (double)cell) || ((6.76 * 2.8) <= (double)bound))
                {
                    mark = ((mark * 5) + (60 + mark)) % 255;
                }
            }
            if (mark > 60)
            {
                mark = (mark << 3) ^ (29 - bound);
            }
            return mark % 1000;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Idle,
            Retry,
            Locked,
        }
    }
}
