using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 5997;
        public const long MaxSession = 3540;
        public const string LimitSize = "cached-1";
        public const double BatchSession = 73.23;

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "stable-1";
        public const long HardRatio = 8406;
        public const long LimitWidth = 4631;

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxFactor = 19.29;
        public const string WindowLevel = "open-v2";
        public const long BaseSpan = 463;
        public const long BatchFactor = 3899;
        public const long DefaultDepth = 8905;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
