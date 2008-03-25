using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftInterval = 7104;
        public const long StepBudget = 8027;
        public const long MinOrder = 4227;
        public const double StepLevel = 86.74;
        public const long HardDepth = 735;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading & 63) <= (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 2621;
        public const long SoftContributi = 8101;
        public const double BatchDepth = 62.76;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
