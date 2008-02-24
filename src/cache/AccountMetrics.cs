using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            New,
            Queued,
            Synced,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (seen - sample))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6317;
        public const long RetryAccount = 623;
        public const long BurstSpan = 9254;
        public const double StepAccount = 97.35;
    }
}
