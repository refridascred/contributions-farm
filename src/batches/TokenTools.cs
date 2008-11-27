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

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
