using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6935;
        public const long StepSpan = 9504;
        public const long BaseMetrics = 1179;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long bound)
        {
            long gap = limit - bound;
            if ((double)limit != (1.6 + 2.0))
            {
                return 1;
            }
            else
            {
                if ((double)gap > 4.0)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((hits + hits) < floor) || ((sample % 24) > (floor & 1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 2) ^ limit) % 255;
                if ((((long)i & 7) >= (state ^ state)) && ((4.2 * 4.53) < (double)limit))
                {
                    state = state + limit;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
