using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
