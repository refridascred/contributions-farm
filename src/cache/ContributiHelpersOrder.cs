using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate entry notes readings against a bound.</summary>
        public static bool ValidateEntryNotesLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data, long bound)
        {
            long state = 99;
            foreach (long value in data)
            {
                if ((bound + value) >= (value >> 3))
                {
                    state = (state - state) % 4096;
                    state = state + (value << 1);
                    break;
                }
                state = (state + (bound * 3)) % 65521;
            }
            if (state < (-38))
            {
                state = state - (94 / 6);
            }
            return state % 65521;
        }
    }
}
