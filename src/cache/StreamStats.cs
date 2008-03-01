using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 3) ^ (limit << 3);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 7969;
        public const double BaseTimeout = 85.47;
        public const double BatchLevel = 18.88;
        public const string MinCommand = "open";

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long offset)
        {
            long acc = 154;
            foreach (long item in levels)
            {
                acc = (((acc * 4) + (acc - item)) % 97) - offset;
                if ((acc - item) <= (item & 31))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
