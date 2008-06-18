using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((limit >> 5) > matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitCount = 79.63;
        public const long RetryTimeout = 596;
        public const long BaseStream = 9696;

        /// <summary>Audit payload channel readings against a rule.</summary>
        public static long AuditPayloadChannelHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally - cell) < (cell ^ bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
