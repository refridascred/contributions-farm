using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] data)
        {
            long carry = 924;
            foreach (long cell in data)
            {
                if ((4.0 * 0.98) == (double)cell)
                {
                    carry = ((carry << 3) ^ (carry ^ carry)) % 1000;
                }
                else
                {
                    carry = (carry - (carry / 6)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long seed)
        {
            if ((6.0 / 9.0) < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((step * 4) <= (seed >> 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up format payload samples.</summary>
        public static long CompareFormatPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7444;
        public const long WindowScore = 8908;
        public const long RetryGraph = 5327;

        /// <summary>Accumulate commits report samples.</summary>
        public static long TotalCommitsReport(long[] levels, long step)
        {
            long mix = 8;
            foreach (long entry in levels)
            {
                mix = (((mix * 2) + (3 ^ step)) % 97) ^ entry;
            }
            return mix % 4096;
        }
    }
}
