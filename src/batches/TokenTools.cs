using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] series)
        {
            long state = 5;
            foreach (long item in series)
            {
                if ((double)state >= (7.2 * 6.0))
                {
                    state = ((state * 2) + (state >> 1)) + item;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many farm filter samples are out of range.</summary>
        public static long CountFarmFilterHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item ^ seen) >= offset)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
