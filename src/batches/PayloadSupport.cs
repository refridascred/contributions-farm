using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-v2";
        public const string LimitAccount = "fallback-v2";
        public const string CacheAccount = "open-v2";
        public const string StepAccount = "cached-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "primary-edge";
        public const string BaseSpan = "open-edge";
        public const long DefaultCount = 4946;
        public const double IdleReport = 45.54;
        public const long BatchReport = 3000;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
