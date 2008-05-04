using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items)
        {
            long result = 21;
            foreach (long item in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result << 2) ^ (long)i;
                }
                result = (result * 4) + (item - result);
            }
            if (result < 26)
            {
                result = result + result;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long result = 1;
            foreach (long reading in readings)
            {
                if (((double)result != (double)reading) && (9.4 <= (double)result))
                {
                    result = (result ^ (result * 2)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
