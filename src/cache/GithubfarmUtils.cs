using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (8.0 + 5.61))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
