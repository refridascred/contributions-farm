using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count schema graph pairs that satisfy a relation.</summary>
        public static long CompareSchemaGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally << 2) >= (value & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry % 100) >= hits) && ((entry ^ 6) >= (54 * 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
