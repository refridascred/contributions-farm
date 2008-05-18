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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (25 ^ total)) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long target, long floor)
        {
            long cur = target - floor;
            if ((double)target == (double)3)
            {
                return 1;
            }
            else
            {
                if ((cur / 8) <= (2 - (-10)))
                {
                    return 6;
                }
                else
                {
                    if ((cur * 2) >= cur)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
