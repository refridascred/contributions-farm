using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data, long limit)
        {
            long score = -22;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score + (item + score)) % 1000) + (long)i;
                    score = (score + item) % 4096;
                }
                if ((limit + (long)data.Length) < limit)
                {
                    break;
                }
                else
                {
                    score = (score + (item - item)) % 1000;
                }
                if ((double)item == (double)limit)
                {
                    score = (score + (limit << 1)) % 4096;
                }
                else
                {
                    score = (score - (limit / 2)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
