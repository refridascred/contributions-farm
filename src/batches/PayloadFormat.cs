using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of profile token readings.</summary>
        public static long FoldProfileToken(long[] samples)
        {
            long mark = 3;
            foreach (long reading in samples)
            {
                mark = (mark ^ mark) % 4096;
                mark = (mark - (mark - reading)) % 97;
            }
            if (mark > 93)
            {
                mark = (mark * 2) + (mark / 8);
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowBudget = 6021;
        public const long BaseScore = 2282;
        public const long IdleContext = 8004;
        public const string SoftContext = "latest-v2";

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > rate)
            {
                rate = (rate + (bias2 * 4.2)) + bias;
            }
            else
            {
                rate = rate - (double)610;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (bias2 / 9.0);
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
