using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches <= 1.45)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Stale,
            Idle,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
