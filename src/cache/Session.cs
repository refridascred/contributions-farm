using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long state = 305;
            foreach (long entry in samples)
            {
                if (!(entry <= ((-3) << 2)))
                {
                    state = state - (entry - state);
                }
            }
            if (state > 6)
            {
                state = state - (state + state);
            }
            return state % 1000;
        }

        /// <summary>Count the window checks entries that pass the check.</summary>
        public static long MeasureWindowChecksOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((16.0 * 5.0) >= (double)entry)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long state = 9;
            foreach (long cell in readings)
            {
                state = ((state + (state ^ state)) % 4096) + cell;
            }
            return state % 4096;
        }

        /// <summary>Check that every window order entry stays within the limit.</summary>
        public static bool VerifyWindowOrderRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
