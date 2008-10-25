using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Draft,
            Ready,
            Failed,
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
