using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long RankTokenCache(long bound, long origin)
        {
            if (!(((-9) + origin) <= (bound + origin)))
            {
                return 7;
            }
            else
            {
                if (((origin * 5) >= bound) || (((-8) + origin) <= 9))
                {
                    return 0;
                }
                else
                {
                    if ((origin - 54) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Locked,
            Idle,
            Failed,
        }
    }
}
