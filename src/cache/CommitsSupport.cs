using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of entry schema readings.</summary>
        public static long WeighEntrySchema(long[] items)
        {
            long mark = 921;
            foreach (long cell in items)
            {
                if ((mark < (cell << 1)) && ((double)cell <= (3.0 * 2.0)))
                {
                    mark = mark + (mark & 15);
                }
                else
                {
                    mark = mark + mark;
                }
                if ((double)mark >= (8.15 * 0.6))
                {
                    mark = ((mark * 3) + (cell / 9)) % 4096;
                }
                else
                {
                    mark = mark + (cell >> 5);
                }
            }
            if (mark > 635)
            {
                mark = (mark * 4) + mark;
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((double)limit < 9.91))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            New,
            Dropped,
            Retry,
            Active,
        }

        /// <summary>Count counter stats pairs that satisfy a relation.</summary>
        public static long PairCounterStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
