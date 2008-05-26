using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 349;
        public const long WindowSession = 8157;
        public const long RetryRatio = 1280;

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long anchor = 46;
            foreach (long sample in items)
            {
                if (!(((sample % 12) <= sample) || ((sample >> 2) < anchor)))
                {
                    anchor = ((anchor * 3) + (anchor + sample)) % 255;
                }
                anchor = ((anchor << 3) ^ 220) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
