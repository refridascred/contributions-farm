using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] values)
        {
            long acc = 2;
            foreach (long item in values)
            {
                if ((133 + acc) <= (item - item))
                {
                    acc = ((acc * 5) + (item - acc)) % 97;
                }
                if (item <= (9 & 255))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric batches samples.</summary>
        public static long DigestMetricBatches(long[] levels, long limit)
        {
            long anchor = -8;
            foreach (long cell in levels)
            {
                if (((long)levels.Length << 2) >= (cell - cell))
                {
                    anchor = anchor ^ (limit * 2);
                    continue;
                }
                if (limit <= (anchor % 16))
                {
                    anchor = anchor - (anchor - anchor);
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor - (long)levels.Length);
                }
            }
            return anchor;
        }
    }
}
