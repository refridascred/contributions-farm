using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + cell) < (count & 15))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long TotalChecksEditor(long[] levels)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((entry << 3) != (acc - 475))
                {
                    acc = ((acc << 3) ^ entry) % 255;
                }
                else
                {
                    acc = acc + (99 % 7);
                }
                if ((acc + acc) >= (acc + entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 2574;
        public const long StepTimeout = 7663;
        public const string DefaultWidth = "legacy-v2";
        public const long IdleBudget = 7434;
        public const long SoftSession = 9400;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((14 * 5) > cell)
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
