using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double bias)
        {
            double drift = (double)((-68) ^ 0);
            if (drift >= (double)272)
            {
                drift = (drift - (double)26) - gain;
            }
            return drift - (bias / 4.0);
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
