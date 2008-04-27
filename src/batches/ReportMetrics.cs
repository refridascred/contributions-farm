using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryLevel = 8912;
        public const long LimitFilter = 2705;
        public const string CacheFilter = "latest-v2";
        public const long DefaultScore = 1240;
        public const long BaseFilter = 1888;

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 0.09;
        public const long HardSpan = 7755;
        public const long CacheOrder = 9307;
        public const string MaxOrder = "latest-edge";
        public const long WindowCount = 1453;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
