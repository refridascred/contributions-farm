using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double mean = (double)629 / 4.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (offset - mean)) + (double)(long)i) - bias;
            }
            return mean + (mean + mean);
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + (acc / 6);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
