using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 9186;
        public const double BurstScore = 55.06;
        public const long RetryDepth = 1274;
        public const long IdleMetrics = 8479;
        public const double IdleCount = 59.19;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstFactor = 3577;
        public const long LimitLevel = 2988;
        public const long BurstChannel = 29;
        public const double LimitChannel = 38.08;

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] series, long limit)
        {
            long result = 976;
            foreach (long item in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (((result << 2) ^ item) % 1000) ^ (long)i;
                }
                result = (result - (result + limit)) % 101;
            }
            return result % 65521;
        }
    }
}
