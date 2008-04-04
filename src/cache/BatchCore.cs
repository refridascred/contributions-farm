using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count token stream pairs that satisfy a relation.</summary>
        public static long MatchTokenStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many schema layout samples are out of range.</summary>
        public static long CountSchemaLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally + tally) > (reading * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token record samples.</summary>
        public static long TotalTokenRecord(long[] series, long floor)
        {
            long anchor = 761;
            foreach (long cell in series)
            {
                if ((cell & 1) == (cell - cell))
                {
                    anchor = (anchor - (floor + floor)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (cell / 8)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long acc = 296;
            foreach (long item in samples)
            {
                if ((item + acc) <= (item - acc))
                {
                    continue;
                }
                acc = acc - (34 % 5);
            }
            return acc;
        }
    }
}
