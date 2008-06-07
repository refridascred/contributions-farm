using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((state ^ step) > ((long)i + step)))
                {
                    state = (state + (step & 15)) % 255;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits - hits) <= (limit - value)) || ((hits >> 1) > (67 + limit)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items)
        {
            long anchor = 93;
            foreach (long datum in items)
            {
                anchor = ((anchor - (anchor + 431)) % 65521) + datum;
            }
            return anchor;
        }
    }
}
