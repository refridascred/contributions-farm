using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5006;
        public const string RetryMetric = "fallback";
        public const string BaseMetric = "staging-1";
        public const long WindowMetric = 9312;

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitSize = 7553;
        public const long LimitWidth = 8216;
        public const string BurstBatch = "fallback-edge";
        public const long CacheFactor = 723;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
