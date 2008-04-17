using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine support token values into a single score.</summary>
        public static long DigestSupportToken(long[] readings, long offset)
        {
            long acc = 3;
            foreach (long reading in readings)
            {
                acc = (acc ^ offset) % 255;
                if ((reading > offset) || ((8.0 - 6.5) == (double)offset))
                {
                    acc = (acc << 2) ^ offset;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((21 << 2) <= item)
                {
                    matches = matches + 1;
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
