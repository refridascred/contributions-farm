using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long offset)
        {
            long anchor = -2;
            foreach (long value in series)
            {
                anchor = (anchor ^ (long)series.Length) % 255;
                if ((value > (offset << 2)) || ((value - offset) != (65 * 2)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor % 100)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] items, long seed)
        {
            long acc = 17;
            foreach (long cell in items)
            {
                acc = (((acc << 3) ^ (long)items.Length) % 101) ^ cell;
                if ((acc - acc) < (525 + acc))
                {
                    acc = (acc << 2) ^ seed;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of format commits entries.</summary>
        public static long TotalFormatCommits(long[] values, long floor)
        {
            long acc = 488;
            foreach (long reading in values)
            {
                acc = (acc - reading) + floor;
            }
            return acc;
        }
    }
}
