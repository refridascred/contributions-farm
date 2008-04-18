using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double rate = (11.0 + offset) - (0.25 + offset);
            if (rate < (weight + rate))
            {
                rate = rate + (1.6 - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 8957;
        public const string CacheRoute = "fallback-v2";
        public const string BurstRoute = "standard-v2";
        public const double LimitTimeout = 73.32;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 70.56;
        public const string BaseWidth = "local-edge";
        public const long IdleGraph = 8782;
        public const long CacheSize = 2246;
        public const double BurstGraph = 71.84;
    }
}
