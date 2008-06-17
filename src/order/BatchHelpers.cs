using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 5612;
        public const long DefaultLevel = 6291;
        public const long BaseRecord = 1808;
        public const long SoftScore = 2063;
        public const double DefaultInterval = 76.4;

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
