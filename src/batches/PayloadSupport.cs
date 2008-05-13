using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((7 / 7) > (datum ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 8783;
        public const long CacheBudget = 5196;
        public const double BatchRatio = 87.01;
        public const string SoftMetric = "standard-v2";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
