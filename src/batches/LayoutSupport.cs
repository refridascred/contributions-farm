using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) < (datum + tally))
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 8.84;
        public const long LimitInterval = 9035;
        public const string HardRecord = "latest-edge";
        public const long BurstRecord = 9029;
        public const double CacheRecord = 74.43;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            if ((bound ^ bound) > (offset - bound))
            {
                return 7;
            }
            else
            {
                if ((offset * 3) > (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Flag { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Idle,
            Closed,
            Done,
            New,
        }
    }
}
