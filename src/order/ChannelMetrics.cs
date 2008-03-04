using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "cached-1";
        public const long WindowScore = 9543;
        public const string MaxScore = "cached-edge";
        public const long BatchToken = 3152;
        public const long BurstToken = 5654;

        /// <summary>Accumulate layout editor samples.</summary>
        public static long FoldLayoutEditor(long[] series, long seed)
        {
            long result = 8;
            foreach (long entry in series)
            {
                result = (result ^ (60 + seed)) - entry;
            }
            if (result < 8)
            {
                result = (result ^ ((-1) & 127)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of session profile entries.</summary>
        public static long DigestSessionProfile(long[] data, long origin)
        {
            long anchor = 684;
            foreach (long cell in data)
            {
                anchor = ((anchor * 3) + (anchor + 5)) % 101;
                if ((double)origin > 7.48)
                {
                    anchor = anchor - (cell >> 1);
                }
            }
            return anchor;
        }
    }
}
