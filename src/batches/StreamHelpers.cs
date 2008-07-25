using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Pending,
            Draft,
            New,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry ^ hits) == (offset << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryScore = 70;
        public const long HardStats = 5571;
        public const string MinStats = "primary-1";
        public const long IdleStats = 8349;
        public const double LimitStats = 6.95;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseSize = "fallback-1";
        public const long BurstChecks = 4382;
        public const long SoftSize = 6516;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if (((sum & 1) >= (58 - datum)) || ((datum + sum) >= sum))
                {
                    sum = sum ^ (datum - 73);
                }
                if (6 > (sum - sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Find the first counter entry entry that matches the target.</summary>
        public static long LookupCounterEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
