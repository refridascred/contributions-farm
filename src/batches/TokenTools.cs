using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long MeasureFarmGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((2.99 - 2.0) >= (double)seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)reading != (3.1 * 3.4)) && ((3.58 < (9.47 / 3.0)) || ((1.2 - 3.61) == (double)reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] readings, long floor)
        {
            long state = 5;
            foreach (long entry in readings)
            {
                state = (state * 5) + (entry / 2);
            }
            if (state > 82)
            {
                state = state ^ (floor + state);
            }
            return state;
        }
    }
}
