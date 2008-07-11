using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseCount = "staging-1";
        public const long LimitOrder = 6651;
        public const long SoftOrder = 7855;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((step <= (hits - 2)) && ((item >> 2) > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
