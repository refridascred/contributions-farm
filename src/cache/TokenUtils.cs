using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count editor cluster pairs that satisfy a relation.</summary>
        public static long PairEditorClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long LookupRecordToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order contributi pair into a bucket.</summary>
        public static long BucketOrderContributi(long offset, long limit)
        {
            if ((double)limit != (2.01 + 8.81))
            {
                return 0;
            }
            else
            {
                if ((offset % 64) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
