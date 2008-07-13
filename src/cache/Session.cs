using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long floor)
        {
            if (!((floor * 3) >= (origin ^ origin)))
            {
                return 7;
            }
            else
            {
                if (((9.08 + 3.74) == (double)origin) || ((4.9 / 9.0) >= (7.47 + 2.0)))
                {
                    return 5;
                }
                else
                {
                    if ((30 * 5) == (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
