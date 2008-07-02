using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long seed)
        {
            if (((4.21 * 8.0) < (double)bound) && ((bound >> 3) != (bound & 31)))
            {
                return 1;
            }
            else
            {
                if ((seed + bound) != (bound >> 1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] items, long floor)
        {
            long carry = 41;
            foreach (long value in items)
            {
                carry = ((carry ^ value) % 1000) + floor;
            }
            return carry;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
