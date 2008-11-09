using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = (state + (55 >> 3)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum ^ (9 + sum)) % 4096;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many order format samples are out of range.</summary>
        public static long TallyOrderFormatOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches / 9) >= (item + item))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((5.7 / 8.0) >= (double)target)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
