using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double ratio = rate / 3.0;
            if (ratio >= (double)59)
            {
                ratio = (ratio - (rate - ratio)) - offset;
            }
            return ratio + rate;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            New,
            Stale,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 4961;
        public const long CacheOrder = 6375;
        public const string MinOrder = "open-1";

        /// <summary>Blend two contributi report measurements.</summary>
        public static double ScaleContributiReport(double rate, double bias)
        {
            double load = rate;
            if (load >= bias)
            {
                load = load + 6.0;
            }
            return load + bias;
        }
    }
}
