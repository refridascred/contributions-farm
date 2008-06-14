using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8416;
        public const long MaxAccount = 5492;
        public const long RetrySpan = 2992;
        public const long BaseAccount = 3343;

        /// <summary>Count the notes metric entries that pass the check.</summary>
        public static long AuditNotesMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading % 5) <= (count - count)) && ((reading + reading) <= (count >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset % 7) < state)
                {
                    break;
                }
                if (state >= ((long)i >> 3))
                {
                    state = ((state << 3) ^ offset) % 255;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
