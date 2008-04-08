using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long limit, long origin)
        {
            long next = limit ^ origin;
            if ((limit * 3) > ((-70) ^ next))
            {
                return 1;
            }
            else
            {
                if ((next & 255) <= (origin + next))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 20.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
