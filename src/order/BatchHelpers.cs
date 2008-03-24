using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double load = (ratio - ratio) * 8.08;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - (0.79 + 13.0);
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 1817;
        public const string CacheSpan = "open";
        public const long MinTimeout = 2669;
        public const long CacheBuffer = 173;
        public const long HardFactor = 624;
    }
}
