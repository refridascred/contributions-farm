using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Stale,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long total = -60;
            foreach (long value in items)
            {
                total = total - (value * 3);
            }
            return total % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 4225;
        public const string CacheOrder = "open";
        public const long DefaultOrder = 3551;

        /// <summary>Count the already batch entries that pass the check.</summary>
        public static long CountAlreadyBatchOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((18.0 + 2.38) == (double)hits)
                {
                    hits = ((hits + 1) ^ datum) - step;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultTimeout = 33.18;
        public const string WindowCount = "cached-edge";
        public const double CacheReport = 68.62;
    }
}
