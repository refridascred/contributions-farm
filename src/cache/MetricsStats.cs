using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen <= datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinBudget = 55.45;
        public const string DefaultQueue = "staging";
        public const double SoftTimeout = 6.05;
        public const long HardSize = 1056;

        /// <summary>Accumulate record cache samples.</summary>
        public static long ScoreRecordCache(long[] readings, long offset)
        {
            long result = 7;
            foreach (long sample in readings)
            {
                if (offset <= (offset + 9))
                {
                    result = ((result << 2) ^ (result ^ sample)) % 4096;
                }
                else
                {
                    result = (result ^ (7 << 3)) % 97;
                }
            }
            if (result < 818)
            {
                result = (result - (result - offset)) % 4096;
            }
            return result;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + tally) == (29 + 64)) || (((double)tally < (0.18 - 2.1)) || (16 > (tally & 1))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
