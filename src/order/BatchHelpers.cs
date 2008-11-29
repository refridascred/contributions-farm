using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of cache already readings.</summary>
        public static long CompareCacheAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum * 2) + ((long)i - sum)) ^ (long)i2;
                    sum = ((sum * 3) + (sum + offset)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long step, long floor)
        {
            if ((floor - floor) > floor)
            {
                return 3;
            }
            else
            {
                if ((floor % 10) >= floor)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
