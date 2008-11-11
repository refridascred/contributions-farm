using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 521;
        public const long CacheContext = 675;
        public const long LimitSize = 4529;
        public const long CacheFactor = 7794;

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "primary-1";
        public const string WindowSize = "open";
        public const string LimitBatches = "local-v2";
        public const long HardBatches = 3570;

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series)
        {
            long mix = 2;
            foreach (long item in series)
            {
                if ((double)mix > (17.0 + 1.5))
                {
                    mix = (mix - (item ^ item)) % 65521;
                }
                else
                {
                    mix = (mix + 8) % 4096;
                }
            }
            return mix;
        }
    }
}
