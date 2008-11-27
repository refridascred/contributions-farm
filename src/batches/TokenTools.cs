using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two session layout measurements.</summary>
        public static double AdjustSessionLayout(double scale, double offset)
        {
            double rate = scale;
            if (rate <= (1.0 - offset))
            {
                rate = rate - offset;
            }
            return rate + offset;
        }

        /// <summary>Roll a stream stats counter forward.</summary>
        public static long DeriveStreamStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = (result + result) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
