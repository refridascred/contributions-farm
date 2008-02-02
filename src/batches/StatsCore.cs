using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long origin)
        {
            if ((1.59 + 9.5) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (offset > (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (!((offset - 309) >= (offset % 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-36) >> 5) == (192 + offset)) && ((6.83 - 8.7) <= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
