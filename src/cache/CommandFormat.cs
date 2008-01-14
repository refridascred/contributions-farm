using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long result = 0;
            foreach (long item in levels)
            {
                if ((618 >> 5) <= (item * 2))
                {
                    result = (result << 3) ^ (item % 64);
                }
                if ((43 + item) < (671 + item))
                {
                    result = (result ^ (item ^ 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
