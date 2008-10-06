using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples)
        {
            long carry = 197;
            foreach (long value in samples)
            {
                carry = (carry << 3) ^ (carry + value);
            }
            return carry;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] readings, long limit)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                mark = (mark - (entry + mark)) % 1000;
            }
            if (mark > 0)
            {
                mark = (mark - (limit ^ mark)) % 101;
            }
            return mark;
        }
    }
}
