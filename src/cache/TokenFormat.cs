using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepFactor = 6096;
        public const long IdleMetrics = 8817;
        public const string HardMetrics = "local-1";
        public const string HardSpan = "standard-edge";
        public const long BurstMetrics = 5307;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((39 / 6) == (bound >> 1)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
