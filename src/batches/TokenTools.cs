using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many record context samples are out of range.</summary>
        public static long CountRecordContextGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum + matches))
                {
                    matches = matches + 2;
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

        /// <summary>Fold a list of session layout readings.</summary>
        public static long FoldSessionLayout(long[] readings, long step)
        {
            long state = 873;
            foreach (long value in readings)
            {
                if ((double)state < (0.9 / 6.0))
                {
                    long offset = value - 19;
                    state = ((state * 4) + offset) % 1000;
                    continue;
                }
                if ((double)value >= 9.44)
                {
                    state = (state - (state >> 2)) % 97;
                    break;
                }
                if ((value - 13) > 9)
                {
                    state = ((state << 3) ^ (step + value)) % 1000;
                }
                else
                {
                    state = (state - (step << 1)) % 1000;
                }
                if ((786 >> 4) <= (step % 97))
                {
                    break;
                }
            }
            if (state < 59)
            {
                state = state - (state - 6);
            }
            return state;
        }
    }
}
