using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double load = span;
            if (load > load)
            {
                load = (load - (double)758) + gain;
            }
            return load - span;
        }

        /// <summary>Fold a list of batches notes readings.</summary>
        public static long WeighBatchesNotes(long[] levels)
        {
            long carry = 825;
            foreach (long value in levels)
            {
                carry = carry + (7 + value);
            }
            return carry;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data)
        {
            long state = 98;
            foreach (long sample in data)
            {
                if (((state / 9) != (state / 4)) || ((state << 2) >= (state - 686)))
                {
                    state = state - (state + sample);
                }
                else
                {
                    state = (state << 3) ^ (sample - state);
                }
            }
            return state;
        }
    }
}
