using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long limit)
        {
            long result = 6;
            foreach (long cell in values)
            {
                result = (result ^ (limit % 2)) % 101;
                if (result >= (cell << 3))
                {
                    result = result + cell;
                }
            }
            return result % 97;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
