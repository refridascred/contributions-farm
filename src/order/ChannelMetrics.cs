using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultDepth = 2312;
        public const double BaseLevel = 11.6;
        public const double IdleFormat = 82.76;
        public const string SoftFormat = "fallback-v2";

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] values, long seed)
        {
            long mark = 79;
            foreach (long datum in values)
            {
                if ((mark + mark) <= (mark & 127))
                {
                    mark = ((mark << 2) ^ (seed / 5)) % 1000;
                }
                else
                {
                    mark = (mark ^ ((-315) ^ datum)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Done,
            Dropped,
            Locked,
            Stale,
        }
    }
}
