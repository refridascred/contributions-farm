using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine window context values into a single score.</summary>
        public static long WeighWindowContext(long[] series, long seed)
        {
            long state = 8;
            foreach (long reading in series)
            {
                if ((double)state < (2.0 + 1.69))
                {
                    state = (((state * 5) + (state + state)) + reading) + seed;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Done,
        }

        /// <summary>Grade a route order value against two limits.</summary>
        public static long ClassifyRouteOrder(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((limit >= (prev >> 1)) && ((384 - 955) >= limit))
            {
                return 0;
            }
            else
            {
                if (prev > (limit << 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 60) <= (7 / 9))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }
    }
}
