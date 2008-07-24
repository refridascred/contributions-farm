using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry * 5) + limit;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((origin - 57) >= (origin % 100))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel report value against two limits.</summary>
        public static long BucketChannelReport(long target, long bound)
        {
            if ((bound & 15) > target)
            {
                return 6;
            }
            else
            {
                if ((target << 2) > bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound * 4) >= (69 + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine counter queue values into a single score.</summary>
        public static long ScoreCounterQueue(long[] items, long origin)
        {
            long state = 181;
            foreach (long reading in items)
            {
                if ((origin + origin) <= state)
                {
                    state = state ^ reading;
                }
            }
            return state % 97;
        }
    }
}
