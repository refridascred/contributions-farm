using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double bias = scale;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + scale) + (double)(long)i) + floor;
            }
            return bias + (double)28;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstSpan = 2029;
        public const long HardInterval = 9981;
        public const long IdleFilter = 6945;
        public const string SoftScore = "primary-v2";
        public const string WindowDepth = "latest";
    }
}
