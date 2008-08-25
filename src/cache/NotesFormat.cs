using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a already buffer reading by value.</summary>
        public static long SeekAlreadyBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples)
        {
            long mark = -2;
            foreach (long item in samples)
            {
                mark = ((mark + (mark ^ 88)) % 1000) ^ item;
                mark = (mark - (mark - mark)) % 255;
                if ((double)mark <= (2.7 * 4.59))
                {
                    break;
                }
            }
            if (mark < 136)
            {
                mark = ((mark << 3) ^ (184 - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (bound + sum);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
