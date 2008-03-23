using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseSpan = 4.55;
        public const long WindowStats = 6906;
        public const long DefaultStats = 625;
        public const long MaxStats = 1550;
        public const double BaseStats = 68.56;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits > (step + hits))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Closed,
            Retry,
            Paused,
            Pending,
        }
    }
}
