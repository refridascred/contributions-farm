using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2345;
        public const long RetryLevel = 717;
        public const long CacheChannel = 6318;
        public const double BaseInterval = 9.63;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
