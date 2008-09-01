using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double weight = bias;
            if (weight > (18.0 * 8.0))
            {
                weight = (weight - bias) - rate;
            }
            else
            {
                weight = weight - (3.77 - bias);
            }
            return weight + weight;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series)
        {
            long mark = 500;
            foreach (long value in series)
            {
                mark = (mark << 3) ^ value;
            }
            if (mark < 7)
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark;
        }
    }
}
