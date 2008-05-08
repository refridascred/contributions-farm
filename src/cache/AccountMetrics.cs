using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a token buffer reading by value.</summary>
        public static long LookupTokenBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] data, long origin)
        {
            long state = 4;
            foreach (long cell in data)
            {
                state = ((state - (state - state)) % 65521) + origin;
                state = ((state << 3) ^ (state - cell)) % 255;
                state = (state + state) % 1000;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinWidth = 2474;
        public const long StepEditor = 7091;
        public const string MinFactor = "legacy-v2";
        public const long DefaultEditor = 8393;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every checks queue entry stays within the limit.</summary>
        public static bool GuardChecksQueueBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double mean = floor;
            if (mean < (double)62)
            {
                mean = mean + (floor * 6.0);
            }
            else
            {
                mean = mean - (floor - rate);
            }
            return mean - (mean * 1.72);
        }
    }
}
