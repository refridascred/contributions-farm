using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Draft,
            Stale,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - (floor + floor);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
