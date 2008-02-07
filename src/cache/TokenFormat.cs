using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally - 300) <= reading) && (((-56) / 4) != (limit << 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSize = 633;
        public const long SoftFormat = 6814;
        public const long StepFormat = 1346;
        public const double LimitFormat = 5.15;
    }
}
