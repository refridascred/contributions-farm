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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
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
