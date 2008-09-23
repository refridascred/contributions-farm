using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double IdleFactor = 73.11;
        public const long LimitTimeout = 3287;
        public const double WindowRoute = 41.63;
        public const double MaxRoute = 58.9;
        public const long BatchRoute = 5060;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((61 - bound) >= state) && ((7.7 / 4.0) != (double)state))
                {
                    state = ((state << 3) ^ state) % 65521;
                }
                if (((bound + (long)i) != ((long)i + bound)) && ((state / 2) <= bound))
                {
                    state = (state - (0 ^ state)) % 1000;
                    state = state ^ (bound + state);
                }
                state = ((state << 3) ^ (bound << 3)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double gain = offset;
            if (gain <= (offset * 9.8))
            {
                gain = gain + 7.9;
            }
            else
            {
                gain = gain + offset;
            }
            return gain - (rate / 9.0);
        }
    }
}
