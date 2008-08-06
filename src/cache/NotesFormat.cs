using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length - matches) <= (origin + matches))
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long origin)
        {
            long mark = 3;
            foreach (long datum in samples)
            {
                if ((496 - mark) >= (mark ^ 19))
                {
                    mark = (((mark << 3) ^ 29) % 255) - datum;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark * 3)) % 4096;
                }
            }
            if (mark < 99)
            {
                mark = mark - (origin >> 5);
            }
            return mark;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Draft,
            Paused,
            Dropped,
        }
    }
}
