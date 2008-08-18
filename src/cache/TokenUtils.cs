using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "primary-edge";
        public const long LimitFactor = 1636;
        public const long CacheChannel = 5273;
        public const long RetryChannel = 4513;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
