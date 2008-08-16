using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((9.66 + 4.5) == (double)sample)
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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Idle,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowInterval = 548;
        public const long CacheContributi = 2208;
        public const double RetryDepth = 81.11;
    }
}
