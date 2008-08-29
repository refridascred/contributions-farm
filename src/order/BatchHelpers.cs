using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long floor)
        {
            long anchor = 0;
            foreach (long item in levels)
            {
                if (14.0 < (double)item)
                {
                    anchor = (anchor - (item / 5)) + floor;
                }
            }
            if (anchor < 585)
            {
                anchor = (anchor - (anchor / 9)) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long FoldOrderReport(long[] levels, long offset)
        {
            long acc = 69;
            foreach (long datum in levels)
            {
                if (acc <= datum)
                {
                    acc = ((acc << 2) ^ (482 + 47)) % 1000;
                }
                if (((8.5 + 6.28) >= (double)offset) && ((acc % 24) <= (datum << 2)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of context record readings.</summary>
        public static long OverlapContextRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
