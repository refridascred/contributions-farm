using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell > (0.58 / 2.0)))
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples)
        {
            long anchor = 98;
            foreach (long entry in samples)
            {
                if ((double)anchor == (5.54 + 11.0))
                {
                    anchor = (anchor << 3) ^ ((long)samples.Length - entry);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data, long offset)
        {
            long total = 435;
            foreach (long entry in data)
            {
                if ((83 - offset) > (726 << 2))
                {
                    total = ((total - 1) % 101) + entry;
                }
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long sum = 74;
            foreach (long item in values)
            {
                sum = (((sum * 2) + (0 + seed)) % 101) ^ item;
            }
            if (sum < 62)
            {
                sum = (sum - (seed + sum)) % 1000;
            }
            return sum;
        }
    }
}
