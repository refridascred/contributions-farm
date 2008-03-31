using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long bound, long origin)
        {
            if (290 > (bound << 1))
            {
                return 3;
            }
            else
            {
                if ((27 + origin) >= (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if (origin > (origin ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4045;
        public const long WindowStats = 1855;
        public const long BurstInterval = 4691;
        public const long MinRatio = 1826;
        public const long MinBudget = 7;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long AuditBatchContextMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((double)(long)samples.Length < (13.0 - 19.0)))
                {
                    hits = ((hits + 2) ^ value) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7652;
        public const double BurstSession = 48.59;
        public const long IdleSession = 6629;
        public const long SoftSession = 9798;
        public const double BaseSession = 90.09;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - origin) <= (count - origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
