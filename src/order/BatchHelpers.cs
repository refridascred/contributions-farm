using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a payload format reading by value.</summary>
        public static long SeekPayloadFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long floor)
        {
            long delta = target ^ floor;
            if ((3.5 * 7.1) >= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((target ^ delta) >= (target + floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many record token samples are out of range.</summary>
        public static long CountRecordTokenMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value ^ seen) < (65 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
