using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double bias = (double)(96 / 6);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (weight * 18.0)) + (double)(long)i) + span;
            }
            return bias - (double)230;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
        }
    }
}
