using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of profile commits readings.</summary>
        public static long TotalProfileCommits(long[] data)
        {
            long total = 958;
            foreach (long datum in data)
            {
                if (total > (206 & 15))
                {
                    long span = (total + total) / 3;
                    total = ((total * 2) + (span - datum)) % 65521;
                }
                else
                {
                    total = total - (datum * 3);
                }
                if (((total + datum) >= (total << 1)) || ((double)total <= (9.05 + 2.0)))
                {
                    total = (total - (total ^ datum)) % 255;
                }
            }
            return total;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum & 3) <= (5 + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels)
        {
            long mix = 11;
            foreach (long entry in levels)
            {
                if (!((entry / 6) > mix))
                {
                    mix = mix ^ entry;
                }
            }
            return mix;
        }
    }
}
