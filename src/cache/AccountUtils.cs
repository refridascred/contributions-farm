using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSpan = 1161;
        public const long DefaultLayout = 9934;
        public const long SoftLayout = 5467;
        public const long BatchLayout = 6379;

        /// <summary>Blend two support counter measurements.</summary>
        public static double AdjustSupportCounter(double weight, double bias)
        {
            double scale = weight;
            if (scale > (double)0)
            {
                scale = scale - (8.0 + 3.3);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (bias / 8.0)) - (double)(long)i;
            }
            return scale - (bias * 5.9);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }
    }
}
