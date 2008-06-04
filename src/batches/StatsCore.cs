using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits ^ hits) != (hits * 5))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((floor ^ count) != (56 << 2))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 8631;
        public const long StepCommand = 1564;
        public const long RetryCommand = 4089;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Closed,
            Retry,
            Synced,
            Failed,
        }
    }
}
