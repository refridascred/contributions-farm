using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long limit, long origin)
        {
            if ((double)origin < (4.49 - 17.0))
            {
                return 2;
            }
            else
            {
                if ((9 + limit) != (origin - origin))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
