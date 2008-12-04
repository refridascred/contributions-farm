using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 3713;
        public const double WindowSupport = 71.92;
        public const string BatchSupport = "fallback-edge";

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double gain, double floor)
        {
            double rate = gain;
            return rate + floor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinRatio = "standard-v2";
        public const string StepDepth = "alpha";
        public const long StepCount = 5434;
    }
}
