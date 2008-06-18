using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long acc = 42;
            foreach (long reading in readings)
            {
                if ((acc >> 1) < acc)
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 65521;
                }
                else
                {
                    acc = acc + (acc - reading);
                }
            }
            if (acc < 194)
            {
                acc = acc ^ (acc << 1);
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7409;
        public const double CacheCounter = 3.53;
        public const string MinWidth = "cached-1";

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) == (count + 135))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
