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

        /// <summary>Scale a tools queue figure with a bias.</summary>
        public static double AdjustToolsQueue(double bias, double bias2)
        {
            double weight = (8.89 - bias) / 8.0;
            if (weight >= (double)776)
            {
                weight = (weight + weight) - bias2;
            }
            return weight + bias;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
