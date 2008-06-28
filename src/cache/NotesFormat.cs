using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Audit metrics entry readings against a rule.</summary>
        public static long CountMetricsEntryGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen < (origin + origin)) || ((double)cell <= (double)36))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long mark = 5;
            foreach (long sample in samples)
            {
                mark = (mark ^ sample) % 101;
                if ((mark << 2) != (mark % 5))
                {
                    mark = ((mark << 3) ^ (sample * 2)) % 101;
                }
            }
            return mark % 65521;
        }
    }
}
