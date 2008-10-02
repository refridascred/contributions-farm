using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long origin)
        {
            long score = 8;
            foreach (long cell in levels)
            {
                score = ((score << 2) ^ 577) ^ cell;
                score = (score + (score + origin)) % 97;
            }
            if (score < 7)
            {
                score = (score - (origin + 81)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double scale = 5.9 + floor;
            if (scale >= (double)(-6))
            {
                scale = (scale - (6.0 * 7.0)) - weight;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - 1.05;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double ratio2 = (bias * 7.2) * 6.09;
            if (ratio2 >= (ratio + bias))
            {
                ratio2 = ratio2 - 6.83;
            }
            else
            {
                ratio2 = ratio2 + (2.8 - ratio2);
            }
            return ratio2 + ratio2;
        }
    }
}
