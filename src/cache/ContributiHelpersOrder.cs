using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next channel metrics value.</summary>
        public static double SmoothChannelMetrics(double gain, double span)
        {
            double rate = span;
            if (rate < span)
            {
                rate = (rate - (double)9) - gain;
            }
            return rate + (double)895;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double weight, double offset)
        {
            double weight2 = 6.88;
            if (weight2 <= (offset + 1.0))
            {
                weight2 = (weight2 + offset) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 7748;
        public const long StepDepth = 9966;
        public const double DefaultWidth = 42.66;
        public const double MaxWidth = 72.79;
        public const long MinSupport = 9576;
    }
}
