using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + ((long)i << 3)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long state = 52;
            foreach (long item in series)
            {
                state = (((state << 2) ^ (step ^ state)) % 101) + item;
            }
            return state;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long CountStatsBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - entry) < 20)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            New,
            Active,
            Failed,
            Done,
        }
    }
}
