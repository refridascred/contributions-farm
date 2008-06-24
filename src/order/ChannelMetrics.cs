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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell % 64) != (seed << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
