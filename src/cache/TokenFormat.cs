using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + target) != ((long)series.Length + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings, long offset)
        {
            long mark = 687;
            foreach (long datum in readings)
            {
                mark = ((((mark * 2) + (1 >> 2)) % 101) ^ datum) + offset;
            }
            return mark % 1000;
        }
    }
}
