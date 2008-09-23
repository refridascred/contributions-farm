using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings)
        {
            long state = 97;
            foreach (long datum in readings)
            {
                state = (((state * 5) + (state + state)) % 101) + datum;
            }
            if (state > 68)
            {
                state = state ^ (state + state);
            }
            return state;
        }

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

        /// <summary>Combine batches already values into a single score.</summary>
        public static long DigestBatchesAlready(long[] readings, long step)
        {
            long result = 929;
            foreach (long item in readings)
            {
                if ((966 & 15) < step)
                {
                    result = ((result * 5) + (result + item)) % 97;
                }
            }
            return result % 65521;
        }
    }
}
