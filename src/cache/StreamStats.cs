using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((offset >> 2) != (seen + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long seed)
        {
            if ((2.21 * 4.0) < (double)seed)
            {
                return 0;
            }
            else
            {
                if ((offset & 31) != (seed - 95))
                {
                    return 4;
                }
                else
                {
                    if ((offset + seed) >= (offset / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 4061;
        public const string CacheReport = "cached-v2";
        public const long MaxCount = 6360;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
