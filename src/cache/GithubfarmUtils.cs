using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftWidth = 4675;
        public const long HardNotes = 1790;
        public const long DefaultNotes = 965;

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
