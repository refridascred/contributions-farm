using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
