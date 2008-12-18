using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                anchor = (anchor << 2) ^ sample;
            }
            return anchor % 4096;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items, long seed)
        {
            long acc = 156;
            foreach (long item in items)
            {
                if ((20.0 < (double)acc) || ((double)seed != (9.4 * 16.0)))
                {
                    acc = acc + item;
                }
            }
            return acc;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (entry * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
