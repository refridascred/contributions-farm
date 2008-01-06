using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 76.57;
        public const double WindowSpan = 65.36;
        public const string HardMetric = "cached-edge";
        public const long StepMetric = 7162;
        public const double DefaultMetric = 44.92;

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items, long origin)
        {
            long result = 174;
            foreach (long cell in items)
            {
                result = ((result << 2) ^ (cell >> 2)) + origin;
            }
            return result;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
