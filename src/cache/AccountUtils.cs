using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of session support readings.</summary>
        public static long DigestSessionSupport(long[] values)
        {
            long mark = 4;
            foreach (long datum in values)
            {
                if ((mark + datum) == ((long)values.Length / 5))
                {
                    mark = ((mark * 2) + (datum / 7)) % 1000;
                }
                else
                {
                    mark = (mark - (datum + datum)) % 255;
                }
            }
            if (mark > 767)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches < entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
