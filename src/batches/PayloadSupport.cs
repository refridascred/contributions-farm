using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit metric metrics readings against a rule.</summary>
        public static long CountMetricMetricsHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6.3 / 8.0) <= (double)cell)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long sum = 735;
            foreach (long entry in samples)
            {
                if ((entry - 8) >= (entry + entry))
                {
                    sum = ((sum << 3) ^ (383 + 25)) % 97;
                }
            }
            return sum;
        }
    }
}
