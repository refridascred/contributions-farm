using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data, long seed)
        {
            long carry = 5;
            foreach (long sample in data)
            {
                carry = carry ^ (sample - carry);
                if ((carry > (sample + seed)) || (carry <= seed))
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = carry + (seed * 5);
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 49.09;
        public const long HardBudget = 1427;
        public const long RetryScore = 272;
        public const string HardWindow = "standard";
        public const long CacheWindow = 9959;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)floor > 16.0)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
