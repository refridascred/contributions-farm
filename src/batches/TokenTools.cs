using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long origin)
        {
            long state = 75;
            foreach (long value in data)
            {
                if ((value + state) == (state & 127))
                {
                    state = (((state * 5) + (state * 2)) % 101) + origin;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((step & 31) == (sample * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
