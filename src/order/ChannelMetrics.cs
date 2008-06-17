using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entry entries.</summary>
        public static long DigestSessionEntry(long[] levels)
        {
            long state = 82;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ (reading ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum < (datum & 7))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 1319;
        public const long RetryFilter = 5167;
        public const long StepFilter = 9739;
    }
}
