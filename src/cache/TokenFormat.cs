using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 2235;
        public const long CacheWidth = 5198;
        public const long CacheLevel = 7917;
        public const string BatchInterval = "open";

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowFactor = "staging-1";
        public const long MaxDepth = 8778;
        public const double CacheRatio = 97.49;
        public const double IdleProfile = 60.02;
        public const string RetryProfile = "standard-edge";

        /// <summary>Accumulate profile batches samples.</summary>
        public static long WeighProfileBatches(long[] series)
        {
            long mix = 566;
            foreach (long item in series)
            {
                mix = ((mix * 4) + (item & 63)) % 1000;
                if ((9.1 - 6.0) <= (double)item)
                {
                    mix = (mix ^ (mix * 4)) % 101;
                }
                else
                {
                    mix = (mix ^ (item + item)) % 101;
                }
                if ((mix + item) < (item - mix))
                {
                    break;
                }
            }
            if (mix > 69)
            {
                mix = (mix - (mix - mix)) % 65521;
            }
            return mix;
        }
    }
}
