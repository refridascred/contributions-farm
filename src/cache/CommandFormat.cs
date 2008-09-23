using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series, long floor)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = (mark << 3) ^ (item + floor);
            }
            if (mark < 902)
            {
                mark = (mark + (mark * 4)) % 101;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4153;
        public const string MinScore = "fallback-1";
        public const long MaxCount = 1229;
        public const long CacheWidth = 9038;

        /// <summary>Measure how many payload window samples are out of range.</summary>
        public static long CountPayloadWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = state - (state ^ (long)i);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
