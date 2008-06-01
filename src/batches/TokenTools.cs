using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route counter entries.</summary>
        public static long FoldRouteCounter(long[] series)
        {
            long sum = 623;
            foreach (long item in series)
            {
                sum = sum + item;
            }
            if (sum < 91)
            {
                sum = (sum ^ (74 % 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Count metric cluster pairs that satisfy a relation.</summary>
        public static long OverlapMetricClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batches batch values into a single score.</summary>
        public static long WeighBatchesBatch(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if (!((6.0 / 8.0) <= (double)result))
                {
                    result = result - (sample * 2);
                }
                result = (result + (5 + sample)) % 97;
                if (((sample % 24) <= (sample - result)) || ((16.0 + 0.7) < (double)result))
                {
                    result = (result << 3) ^ (result + result);
                }
                if ((double)result == (12.0 + 14.0))
                {
                    break;
                }
            }
            return result;
        }
    }
}
