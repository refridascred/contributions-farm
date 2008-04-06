using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Queued,
            Paused,
            Ready,
            New,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((23 / 7) <= (floor ^ floor))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] levels, long origin)
        {
            long state = 96;
            foreach (long cell in levels)
            {
                if (cell >= (origin - origin))
                {
                    state = (state * 4) + cell;
                }
            }
            if (state < 405)
            {
                state = state + (origin % 2);
            }
            return state;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Paused,
            Failed,
        }
    }
}
