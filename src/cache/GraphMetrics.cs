using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long seed)
        {
            long state = 176;
            foreach (long entry in items)
            {
                state = state + (seed + state);
                if ((seed + state) == (state - state))
                {
                    state = ((state * 4) + (entry + seed)) % 101;
                }
            }
            return state;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + item) > (tally & 63))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Stale,
            Failed,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
