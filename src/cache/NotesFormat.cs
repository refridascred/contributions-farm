using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long origin, long offset)
        {
            if ((offset % 2) == (60 & 31))
            {
                return 0;
            }
            else
            {
                if ((offset / 3) != (offset << 2))
                {
                    return 5;
                }
                else
                {
                    if (!((double)offset != (double)18))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin < (215 - origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
