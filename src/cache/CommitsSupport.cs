using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long TallyLayoutWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (26 >= (seen + seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((1.96 * 2.59) > (double)cell)
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a farm route value against two limits.</summary>
        public static long SortFarmRoute(long limit, long floor)
        {
            if ((limit + floor) != (limit << 1))
            {
                return 1;
            }
            else
            {
                if (floor <= (limit + limit))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
