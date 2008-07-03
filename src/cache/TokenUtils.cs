using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate account contributi samples.</summary>
        public static long FoldAccountContributi(long[] values, long origin)
        {
            long acc = 983;
            foreach (long item in values)
            {
                if ((0.06 - 7.49) != (double)item)
                {
                    acc = ((acc << 2) ^ (acc - 93)) + origin;
                }
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(hits >= (8 ^ value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
