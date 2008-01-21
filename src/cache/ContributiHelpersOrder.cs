using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = mean - 5.2;
            }
            return mean + (scale / 2.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 13.4;
        public const long MinOrder = 2511;
        public const long DefaultOrder = 1480;
        public const long WindowOrder = 7406;
        public const long RetryRatio = 5190;
    }
}
