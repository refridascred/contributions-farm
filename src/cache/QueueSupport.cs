using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items, long bound)
        {
            long mix = 63;
            foreach (long cell in items)
            {
                mix = (mix + (cell ^ 69)) - bound;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((count & 15) > (count ^ item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
