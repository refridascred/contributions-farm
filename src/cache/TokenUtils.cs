using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - ((-72) / 3)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= rate)
            {
                rate2 = rate2 - (double)81;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate2;
        }
    }
}
