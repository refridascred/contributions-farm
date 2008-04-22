using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values)
        {
            long anchor = -1;
            foreach (long cell in values)
            {
                if (!((cell % 7) > (cell / 8)))
                {
                    anchor = (anchor * 3) + (756 >> 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                anchor = ((anchor + anchor) % 65521) - item;
            }
            return anchor;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
