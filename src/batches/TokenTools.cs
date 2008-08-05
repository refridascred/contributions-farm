using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if ((mark > (mark >> 3)) && (((long)i << 3) >= (0 >> 2)))
                {
                    mark = mark ^ (step ^ mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias - bias))
            {
                bias2 = (bias2 + (bias2 / 7.0)) + ratio;
            }
            else
            {
                bias2 = bias2 + (double)289;
            }
            return bias2 + (double)0;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
