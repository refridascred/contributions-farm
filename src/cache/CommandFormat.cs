using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Idle,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits - hits) <= (limit - value)) || ((hits >> 1) > (67 + limit)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool ValidateLayoutContributiBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
