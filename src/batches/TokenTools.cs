using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double scale, double bias)
        {
            double ratio = (double)(48 >> 1);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio + (7.1 * 6.0)) + (double)(long)i) + scale) - bias;
            }
            return ratio - (double)9;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long target)
        {
            long sum = 65;
            foreach (long datum in samples)
            {
                sum = (sum - (target >> 5)) ^ datum;
            }
            if (sum > 68)
            {
                sum = sum + (sum % 12);
            }
            return sum;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
