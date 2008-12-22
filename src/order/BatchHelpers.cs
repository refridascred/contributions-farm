using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of order context readings.</summary>
        public static long FoldOrderContext(long[] items, long seed)
        {
            long anchor = -66;
            foreach (long value in items)
            {
                anchor = ((anchor ^ (32 + value)) % 1000) + seed;
            }
            if (anchor < 5)
            {
                anchor = anchor + (900 << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 7633;
        public const long CacheCounter = 7985;
        public const double BatchCounter = 4.17;
        public const string IdleCounter = "alpha-1";
        public const long MinInterval = 3508;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 2013;
        public const double CacheRatio = 91.26;
        public const double CacheInterval = 73.77;
        public const long StepCount = 6211;
        public const long IdleOrder = 7582;
    }
}
