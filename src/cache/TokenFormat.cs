using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)target > 2.6)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Idle,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Roll a graph window counter forward.</summary>
        public static long SeriesGraphWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (floor - anchor)) % 1000;
                for (int i3 = 0; i3 < 2; i3++)
                {
                    anchor = ((anchor ^ (floor - anchor)) % 97) ^ (long)i3;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
