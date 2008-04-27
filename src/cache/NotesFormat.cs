using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((17.0 + 5.59) != (double)offset) && ((((long)series.Length - 82) >= (offset % 3)) || ((seen / 5) <= (offset % 100))))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (mix <= (bound + bound))
                {
                    mix = ((mix << 2) ^ (bound + bound)) % 4096;
                    mix = (mix + (bound - mix)) % 65521;
                }
                if (bound > (bound * 4))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
