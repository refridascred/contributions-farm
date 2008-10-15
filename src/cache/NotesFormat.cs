using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((3.6 + 16.0) > (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry + carry) % 101;
                if ((carry >> 1) <= (1 - 60))
                {
                    carry = (carry ^ (carry & 7)) % 97;
                    continue;
                }
                else
                {
                    carry = (carry + 192) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                if (!(((68 - target) == (anchor + target)) || ((anchor - anchor) <= (target - target))))
                {
                    anchor = (anchor * 5) + anchor;
                }
                anchor = anchor ^ (target ^ 916);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
