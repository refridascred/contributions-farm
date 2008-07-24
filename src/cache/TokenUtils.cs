using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                sum = ((sum - (424 - 76)) % 4096) + cell;
            }
            if (sum > 33)
            {
                sum = ((sum * 4) + (sum + sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 2864;
        public const double RetryTimeout = 0.3;
        public const long DefaultCluster = 5026;
        public const string MaxScore = "primary-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 4209;
        public const long MaxBatch = 4118;
        public const long MinScore = 959;
    }
}
