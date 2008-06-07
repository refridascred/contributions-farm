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

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long sum = 797;
            foreach (long sample in levels)
            {
                if (((long)levels.Length << 2) > ((long)levels.Length >> 4))
                {
                    sum = ((sum << 2) ^ (sum + sample)) % 4096;
                }
                sum = (sum ^ (sum << 3)) % 1000;
            }
            if (sum < 231)
            {
                sum = sum - (sum << 2);
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
