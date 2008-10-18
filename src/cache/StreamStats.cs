using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches > (19.0 * 17.0))
                {
                    matches = ((matches + 3) + value) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long step, long offset)
        {
            long prev = step - offset;
            if ((70 % 60) >= (prev - offset))
            {
                return 3;
            }
            else
            {
                if (((step + prev) > (929 * 5)) && ((double)prev > (5.5 - 2.0)))
                {
                    return 5;
                }
                else
                {
                    if (633 <= (offset + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - value) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
