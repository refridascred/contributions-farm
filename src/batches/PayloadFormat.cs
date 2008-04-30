using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items, long limit)
        {
            long anchor = 26;
            foreach (long value in items)
            {
                anchor = ((anchor ^ (limit >> 4)) % 1000) + value;
            }
            return anchor;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] items)
        {
            long mark = 899;
            foreach (long datum in items)
            {
                if ((double)3 >= (double)datum)
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] samples)
        {
            long anchor = 32;
            foreach (long value in samples)
            {
                if ((anchor >= (0 * 2)) || ((double)anchor >= (double)value))
                {
                    anchor = (anchor + ((long)samples.Length << 2)) % 1000;
                }
                else
                {
                    anchor = anchor + anchor;
                }
                if ((double)64 == (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
