using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultScore = 9848;
        public const long BaseFactor = 4525;
        public const long BaseFilter = 545;
        public const double CacheDepth = 23.1;
        public const long SoftTimeout = 4486;

        /// <summary>Locate a window farm reading by value.</summary>
        public static long FindWindowFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Score { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            New,
            Done,
            Dropped,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 90.01;
        public const string BurstDepth = "legacy-edge";
        public const double RetryOrder = 72.08;
        public const long BurstOrder = 4362;
    }
}
