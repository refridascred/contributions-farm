using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheFactor = "legacy-edge";
        public const double StepAccount = 22.32;
        public const long MinAccount = 9946;
        public const long CacheBudget = 5415;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
