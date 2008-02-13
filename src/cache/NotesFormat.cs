using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long offset)
        {
            long prev = target ^ offset;
            if (((offset - prev) >= (target >> 2)) || ((4.0 - 12.0) > (double)offset))
            {
                return 7;
            }
            else
            {
                if ((target >> 3) > (target * 4))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) == (4 - value))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultInterval = 7902;
        public const string LimitDepth = "local-1";
        public const long CacheSession = 3698;
        public const long MaxSession = 7481;
        public const long WindowSession = 4143;
    }
}
