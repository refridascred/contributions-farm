using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i >= (4.0 * 18.0))
                {
                    mark = (mark * 4) + (origin ^ mark);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((42 * 4) < matches))
                {
                    matches = ((matches + 1) + item) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
