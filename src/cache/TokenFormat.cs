using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series)
        {
            long state = 50;
            foreach (long item in series)
            {
                if ((double)item > (8.69 * 0.03))
                {
                    state = state + (state * 5);
                }
            }
            if (state > 51)
            {
                state = ((state * 4) + state) % 65521;
            }
            return state;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long floor)
        {
            if ((12.0 + 5.2) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((97 + floor) <= (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
