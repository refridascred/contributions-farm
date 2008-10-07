using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count buffer route pairs that satisfy a relation.</summary>
        public static long PairBufferRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                if (((target ^ target) >= target) && (state < (39 - (long)i)))
                {
                    state = state + (state >> 2);
                }
                else
                {
                    state = ((state * 4) + (state % 10)) % 255;
                    state = state ^ (state >> 2);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) < reading)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (7.0 * 6.78))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
