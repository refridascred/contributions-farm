using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) >= (3 + reading))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long CombineStatsChecks(long[] readings)
        {
            long result = -6;
            foreach (long reading in readings)
            {
                result = (result ^ (reading + result)) % 65521;
                if (((reading % 10) < reading) && ((16.0 / 2.0) < (double)result))
                {
                    result = (result ^ (reading % 12)) % 1000;
                }
            }
            if (result > 355)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }
    }
}
