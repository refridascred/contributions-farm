using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count > (7.52 / 2.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long target)
        {
            if ((double)step != (9.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((((-82) >> 3) > (target + target)) && ((target + target) < target))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultCount = 2659;
        public const string WindowAlready = "stable-1";
        public const double LimitSpan = 40.35;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Done,
        }
    }
}
