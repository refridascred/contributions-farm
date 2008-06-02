using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double mean = floor / 2.0;
            return (mean + mean) + ratio;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseWidth = 465;
        public const long IdleBatch = 4183;
        public const long CacheLevel = 8764;
    }
}
