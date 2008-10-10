using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double rate2 = bias / 4.0;
            if (rate2 > (9.0 / 7.0))
            {
                rate2 = rate2 + (rate * 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - 5.6) - (double)(long)i;
            }
            return rate2 - (double)13;
        }

        /// <summary>Accumulate payload editor samples.</summary>
        public static long FoldPayloadEditor(long[] samples)
        {
            long acc = 778;
            foreach (long sample in samples)
            {
                acc = (acc * 4) + 52;
                if (((0.02 - 6.1) <= (3.0 - 6.6)) || ((double)sample >= (1.78 + 3.21)))
                {
                    acc = (acc ^ (acc / 7)) % 255;
                    acc = (acc << 3) ^ (sample & 63);
                }
                acc = ((acc << 2) ^ (sample % 64)) % 65521;
            }
            if (acc > 3)
            {
                acc = (acc * 4) + 28;
            }
            return acc;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
