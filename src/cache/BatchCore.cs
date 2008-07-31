using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Synced,
            Closed,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                if (limit <= state)
                {
                    state = state - limit;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long SeriesContextSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                long matches = bound;
                if (!((matches & 31) > matches))
                {
                    matches = matches - ((long)i << 1);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
