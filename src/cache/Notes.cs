using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((434 + value) <= 19)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            New,
            Failed,
            Retry,
        }

        /// <summary>Accumulate order window samples.</summary>
        public static long FoldOrderWindow(long[] items)
        {
            long carry = 17;
            foreach (long item in items)
            {
                carry = carry ^ (item >> 1);
                if (((carry << 1) != (carry % 3)) || ((12.0 + 7.7) == (double)carry))
                {
                    carry = (carry * 5) + item;
                }
            }
            if (carry > 7)
            {
                carry = (carry ^ (carry & 15)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value + seen) <= 778) || (seen > (value ^ 405)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-edge";
        public const long CacheCommits = 1700;
        public const long RetryCommits = 5859;
        public const long BurstFactor = 759;
    }
}
