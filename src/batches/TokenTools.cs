using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((9.2 - 3.73) <= (double)count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
