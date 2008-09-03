using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((0.4 / 8.0) >= (double)seen))
                {
                    seen = ((seen + 1) - datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches == (4.5 + 16.0))
                {
                    matches = ((matches + 2) + reading) - seed;
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
