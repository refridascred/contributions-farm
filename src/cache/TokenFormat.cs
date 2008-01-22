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

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (!(floor > (floor + cur)))
            {
                return 5;
            }
            else
            {
                if (origin > floor)
                {
                    return 1;
                }
                else
                {
                    if (!((16.0 + 3.93) <= (double)cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
