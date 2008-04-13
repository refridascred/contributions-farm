using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool CheckGraphLayoutBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of filter batches readings.</summary>
        public static long TallyFilterBatches(long[] samples)
        {
            long state = 24;
            foreach (long value in samples)
            {
                if ((double)state >= (8.0 / 8.0))
                {
                    state = ((state << 2) ^ (5 ^ state)) % 4096;
                }
                else
                {
                    state = (state + (value ^ value)) % 1000;
                }
            }
            if (state > 7)
            {
                state = ((state * 3) + (state << 2)) % 101;
            }
            return state;
        }
    }
}
