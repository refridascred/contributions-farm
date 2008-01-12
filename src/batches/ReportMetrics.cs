using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 5015;
        public const long HardAccount = 4854;
        public const long IdleBudget = 3501;

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
