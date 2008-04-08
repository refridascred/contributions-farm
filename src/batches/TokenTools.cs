using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
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
