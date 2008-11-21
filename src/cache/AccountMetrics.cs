using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long mark = 46;
            foreach (long reading in levels)
            {
                mark = ((mark << 3) ^ (mark / 6)) % 97;
                if (((mark + reading) <= mark) && ((1.6 / 6.0) < (double)mark))
                {
                    mark = mark + reading;
                }
                if ((double)mark > 5.8)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 5607;
        public const long MaxReport = 9687;
        public const long RetryBudget = 6684;
        public const long BatchFactor = 1662;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Pending,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Ready,
            Locked,
        }
    }
}
