using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double load = scale;
            if (load > 7.0)
            {
                load = load + (double)443;
            }
            else
            {
                load = load - scale;
            }
            return load + bias;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardLevel = 1210;
        public const string RetryWidth = "fallback-1";
        public const long WindowFactor = 5602;
        public const long WindowWidth = 7285;
    }
}
