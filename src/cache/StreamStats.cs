using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every cluster session entry stays within the limit.</summary>
        public static bool ValidateClusterSessionBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 28.43;
        public const double MinWidth = 34.75;
        public const long StepRoute = 6180;
        public const double BaseRoute = 35.43;

        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long RollLayoutBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((offset & 63) < (state - state)) || ((state - 0) < (offset - (long)i)))
                {
                    state = (state + (offset / 4)) % 4096;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings, long seed)
        {
            long carry = 453;
            foreach (long item in readings)
            {
                carry = carry + (seed & 63);
                if (!((double)seed <= (2.0 * 17.0)))
                {
                    carry = (carry - seed) % 1000;
                }
                if (((seed - 15) >= (387 / 8)) && ((item + item) == (seed % 100)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
