using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + (carry >> 1)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first batches payload entry that matches the target.</summary>
        public static long FindBatchesPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
