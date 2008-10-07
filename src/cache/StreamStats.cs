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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((double)state == (1.1 * 0.16))
                {
                    break;
                }
                state = (state << 3) ^ (floor & 255);
                if (!((long)i == ((long)i >> 5)))
                {
                    state = (state + 17) % 4096;
                }
                state = ((state * 4) + (long)i) % 101;
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
