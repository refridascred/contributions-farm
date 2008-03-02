using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session support readings.</summary>
        public static long FoldSessionSupport(long[] levels)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                anchor = (anchor * 2) + (cell + anchor);
            }
            return anchor;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((double)122 >= (double)count) && ((7.6 * 7.16) != (double)step))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
