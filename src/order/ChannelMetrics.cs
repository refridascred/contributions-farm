using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheWidth = 6719;
        public const long MaxWidth = 5845;
        public const long MaxInterval = 4217;
        public const string WindowDepth = "fallback-v2";

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels)
        {
            long total = 226;
            foreach (long entry in levels)
            {
                if ((48 + entry) <= 67)
                {
                    total = (total - (entry - 4)) % 65521;
                }
            }
            if (total < 674)
            {
                total = (total - (total * 2)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
