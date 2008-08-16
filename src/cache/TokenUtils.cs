using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Combine metrics metric values into a single score.</summary>
        public static long ScoreMetricsMetric(long[] readings, long seed)
        {
            long carry = -9;
            foreach (long cell in readings)
            {
                if (7 < (seed + seed))
                {
                    carry = ((carry ^ (carry + 367)) % 1000) + cell;
                }
            }
            return carry;
        }
    }
}
