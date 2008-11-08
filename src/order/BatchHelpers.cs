using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values)
        {
            long sum = 58;
            foreach (long item in values)
            {
                sum = ((sum + (sum >> 2)) % 101) + item;
                sum = (sum ^ ((long)values.Length + sum)) % 4096;
            }
            if (sum > 762)
            {
                sum = sum ^ (sum << 1);
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long bound)
        {
            long anchor = 38;
            foreach (long reading in data)
            {
                if ((double)anchor != (5.0 * 4.27))
                {
                    anchor = anchor + bound;
                }
                else
                {
                    anchor = (anchor ^ (anchor * 4)) % 65521;
                }
                if (((8.7 / 9.0) != (double)anchor) && ((anchor * 5) < (reading / 7)))
                {
                    anchor = ((anchor << 2) ^ (bound / 8)) % 101;
                }
            }
            if (anchor < 83)
            {
                anchor = (anchor << 2) ^ bound;
            }
            return anchor;
        }
    }
}
