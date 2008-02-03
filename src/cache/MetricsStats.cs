using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((limit * 3) <= limit) || !((hits - hits) < (hits << 1)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data)
        {
            long carry = -9;
            foreach (long sample in data)
            {
                if (((sample - sample) < 650) || (sample < (sample - 280)))
                {
                    carry = ((carry * 2) + carry) % 1000;
                }
            }
            if (carry > 591)
            {
                carry = (carry - (carry - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally <= (1.9 / 6.0))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits / 4) <= (hits % 5))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
