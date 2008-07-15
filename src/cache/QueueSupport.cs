using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((long)data.Length & 63) == (value + count)) && ((624 >= (limit - count)) || ((limit % 8) >= limit)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((offset & 255) < (limit * 4))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) != (origin << 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
