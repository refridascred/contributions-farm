using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 7573;
        public const string LimitSession = "legacy-v2";
        public const long SoftSession = 180;
        public const long CacheSession = 2895;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5592;
        public const double IdleEditor = 97.98;
        public const double MaxEditor = 20.52;
        public const double MinBudget = 1.36;
        public const long DefaultFactor = 2375;

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double ratio = span;
            if (ratio > span)
            {
                ratio = ratio - (double)51;
            }
            return ratio + (scale / 3.0);
        }
    }
}
