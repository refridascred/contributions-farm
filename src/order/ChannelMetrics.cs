using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every channel cluster entry stays within the limit.</summary>
        public static bool VerifyChannelClusterRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 729;
        public const long MaxFormat = 5964;
        public const long DefaultInterval = 7339;
    }
}
