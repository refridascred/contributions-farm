using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count stream commits pairs that satisfy a relation.</summary>
        public static long OverlapStreamCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster stream entries.</summary>
        public static long CombineClusterStream(long[] samples)
        {
            long anchor = 98;
            foreach (long datum in samples)
            {
                if ((1 ^ anchor) >= (datum & 15))
                {
                    anchor = anchor - (anchor & 255);
                }
            }
            if (anchor > 679)
            {
                anchor = anchor + (anchor >> 5);
            }
            return anchor;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
