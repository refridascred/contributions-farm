using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 3103;
        public const double CacheDepth = 11.62;
        public const long DefaultDepth = 5174;
        public const double MinRecord = 63.17;

        /// <summary>Count the profile command entries that pass the check.</summary>
        public static long AuditProfileCommandOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value == (5.0 / 2.0))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                if (((cell >> 2) > cell) || ((cell / 7) < (cell ^ mix)))
                {
                    mix = (mix - (mix + cell)) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
