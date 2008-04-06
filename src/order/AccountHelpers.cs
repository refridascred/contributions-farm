using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the cache buffer series from a seed.</summary>
        public static long SeriesCacheBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = (state + (489 * 5)) % 1000;
                if ((double)state <= 2.4)
                {
                    state = (state * 5) + state;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
