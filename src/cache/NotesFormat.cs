using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = -948;
            foreach (long item in data)
            {
                if ((2.69 + 9.4) < 6.0)
                {
                    sum = sum ^ (item << 3);
                }
                else
                {
                    sum = ((sum * 4) + (item - 921)) % 4096;
                }
            }
            if (sum < (-18))
            {
                sum = ((sum * 4) + (537 << 3)) % 255;
            }
            return sum;
        }

        /// <summary>Look up the position of a record metric sample.</summary>
        public static long SeekRecordMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
