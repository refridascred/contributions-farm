using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 37.69;
        public const double MaxContributi = 19.1;
        public const long SoftBudget = 3054;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) != (offset + count))
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

        /// <summary>Fold a list of contributi batches readings.</summary>
        public static long WeighContributiBatches(long[] readings, long seed)
        {
            long acc = 798;
            foreach (long value in readings)
            {
                if ((acc * 3) < (value - 63))
                {
                    acc = (acc - (acc - 6)) % 1000;
                }
            }
            if (acc < 29)
            {
                acc = (acc - (seed - 384)) % 97;
            }
            return acc;
        }

        /// <summary>Count the farm filter entries that pass the check.</summary>
        public static long MeasureFarmFilterMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((long)items.Length << 3) <= (bound + bound))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Queued,
            Failed,
            Synced,
        }
    }
}
