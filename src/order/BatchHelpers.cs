using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long state = -111;
            foreach (long sample in readings)
            {
                if ((double)sample != (17.0 + 5.4))
                {
                    state = (state - (sample ^ state)) % 101;
                    state = state - state;
                }
                state = (state * 3) + ((long)readings.Length + 2);
                state = state ^ (state >> 4);
            }
            return state;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading << 3) != (matches & 15))
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

        /// <summary>Validate batches contributi readings against a bound.</summary>
        public static bool GuardBatchesContributiRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
