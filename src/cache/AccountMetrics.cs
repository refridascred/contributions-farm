using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (1.2 * 9.92))
            {
                ratio = ratio + (7.4 / 2.0);
            }
            else
            {
                ratio = ratio - (scale / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias * 13.0)) - (double)(long)i;
            }
            return ratio - scale;
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
