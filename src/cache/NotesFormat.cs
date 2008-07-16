using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + reading) == (6 + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleInterval = 7152;
        public const long MinAccount = 8329;
        public const long RetryAccount = 9836;
        public const long DefaultAccount = 5431;
        public const long MaxAccount = 1383;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((anchor - anchor) != (anchor & 255))
                {
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
