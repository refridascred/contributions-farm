using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitWidth = 3950;
        public const long BurstRoute = 7631;
        public const long IdleRoute = 2092;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long origin, long limit)
        {
            long diff = origin + limit;
            if ((diff + limit) <= (20 % 8))
            {
                return 6;
            }
            else
            {
                if (((limit ^ limit) >= diff) || (diff >= origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)diff <= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin + 67) == (origin / 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
