using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next entry stats value from a seed.</summary>
        public static long IterateEntryStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items, long origin)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if ((origin + cell) > 893)
                {
                    continue;
                }
                if (((double)mark == (8.0 / 8.0)) && ((cell >> 1) != (cell * 4)))
                {
                    mark = (mark + origin) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit record metrics readings against a rule.</summary>
        public static long AuditRecordMetricsHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count ^ count) == (count % 64))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
