using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first layout token entry that matches the target.</summary>
        public static long LocateLayoutTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record checks readings against a rule.</summary>
        public static long TallyRecordChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((85 + 27) >= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >> 5) >= hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxSize = 79.37;
        public const long IdleBudget = 9358;
        public const double MaxBudget = 59.0;
        public const string HardFarm = "standard-edge";

        /// <summary>Classify a batch metrics pair into a bucket.</summary>
        public static long RankBatchMetrics(long bound, long offset)
        {
            if ((offset / 8) < (55 + offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (20.0 / 2.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
