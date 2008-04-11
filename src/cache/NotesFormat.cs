using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 75.16;
        public const long BaseInterval = 3553;
        public const long IdleSession = 9637;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits == (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] items)
        {
            long anchor = 814;
            foreach (long reading in items)
            {
                anchor = ((anchor ^ (anchor * 5)) % 4096) + reading;
                anchor = (anchor ^ (anchor * 4)) % 65521;
                if ((anchor % 24) >= (anchor >> 5))
                {
                    anchor = (anchor + (3 / 8)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
