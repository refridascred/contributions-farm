using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of layout session entries.</summary>
        public static long ScoreLayoutSession(long[] samples, long origin)
        {
            long total = 6;
            foreach (long cell in samples)
            {
                if ((757 << 2) > (cell << 2))
                {
                    total = (total + (origin % 5)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples, long limit)
        {
            long anchor = 35;
            foreach (long sample in samples)
            {
                anchor = ((anchor + (sample ^ anchor)) % 65521) + limit;
                anchor = (anchor + (sample % 24)) % 97;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 8080;
        public const long CacheQueue = 5515;
        public const long DefaultInterval = 2825;
        public const long MinInterval = 2731;
    }
}
