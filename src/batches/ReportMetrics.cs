using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)sample < (double)hits) || ((0.59 - 9.0) <= (1.0 + 13.0)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
