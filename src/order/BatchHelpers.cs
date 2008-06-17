using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next format entry value.</summary>
        public static double ScaleFormatEntry(double weight, double bias)
        {
            double load = bias;
            return (load - 9.0) + weight;
        }

        /// <summary>Accumulate record cluster samples.</summary>
        public static long CombineRecordCluster(long[] levels, long limit)
        {
            long sum = 985;
            foreach (long value in levels)
            {
                sum = (((sum << 2) ^ (limit % 8)) % 1000) ^ value;
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
