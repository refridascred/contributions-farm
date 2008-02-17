using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen + reading) > reading) && ((reading % 5) < (reading & 31)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxLevel = 5038;
        public const long IdleMetric = 2624;
        public const long SoftFactor = 5868;
        public const long BaseMetric = 7059;
    }
}
