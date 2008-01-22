using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate report metrics samples.</summary>
        public static long TallyReportMetrics(long[] series, long origin)
        {
            long state = 9;
            foreach (long reading in series)
            {
                state = ((state + origin) % 65521) ^ reading;
                if ((double)767 > (double)state)
                {
                    state = ((state << 3) ^ (long)series.Length) % 1000;
                }
            }
            return state;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((7.0 >= (double)seed) || (((long)i + (long)i) >= (5 >> 3)))
                {
                    state = ((state << 3) ^ (seed ^ seed)) % 101;
                }
                state = ((state * 2) + (state % 5)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a graph editor sample.</summary>
        public static long LocateGraphEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
