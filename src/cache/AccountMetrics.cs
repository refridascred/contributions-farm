using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen >= (3.1 / 9.0))
                {
                    seen = ((seen + 2) - reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Combine checks queue values into a single score.</summary>
        public static long CombineChecksQueue(long[] values)
        {
            long state = 9;
            foreach (long cell in values)
            {
                if (!((17.0 + 3.7) > (double)cell))
                {
                    state = state + (cell / 4);
                }
                state = ((state * 5) + cell) % 255;
            }
            if (state < 7)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((8.93 / 4.0) >= (double)floor)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Combine account metric values into a single score.</summary>
        public static long CombineAccountMetric(long[] values)
        {
            long total = 674;
            foreach (long cell in values)
            {
                total = total ^ (total % 64);
                if (((9.5 * 4.4) > (double)cell) && ((total - cell) != (cell ^ total)))
                {
                    total = ((total * 4) + (cell + cell)) % 97;
                }
            }
            return total % 97;
        }
    }
}
