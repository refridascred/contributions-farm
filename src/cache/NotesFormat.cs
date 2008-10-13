using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of report batch entries.</summary>
        public static long ScoreReportBatch(long[] values, long origin)
        {
            long sum = 42;
            foreach (long datum in values)
            {
                sum = (sum + (origin & 7)) + datum;
                if (origin >= (7 >> 4))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            New,
            Active,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + origin) >= (hits / 3))
                {
                    hits = hits + 1;
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
