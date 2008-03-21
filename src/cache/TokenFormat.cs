using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)item == (double)count) && !((8.47 * 9.0) >= (double)count))
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

        /// <summary>Digest a series of editor graph entries.</summary>
        public static long CombineEditorGraph(long[] readings, long offset)
        {
            long mark = 6;
            foreach (long item in readings)
            {
                mark = (mark ^ item) + offset;
                mark = mark - (item + (-5));
                if ((double)mark >= (double)item)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
