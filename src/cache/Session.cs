using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + tally) <= (tally - 8))
                {
                    tally = ((tally + 3) + item) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Grade a graph filter value against two limits.</summary>
        public static long SortGraphFilter(long seed, long offset)
        {
            if ((seed < offset) && ((seed / 3) == (seed - offset)))
            {
                return 1;
            }
            else
            {
                if ((offset / 8) < (offset >> 2))
                {
                    return 6;
                }
                else
                {
                    if (seed < (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
