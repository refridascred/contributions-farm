using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate payload command readings against a bound.</summary>
        public static bool ValidatePayloadCommandRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next token cluster value from a seed.</summary>
        public static long RollTokenCluster(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc * 4) + (floor * 2)) % 4096) + (long)i2;
                }
                acc = acc - (60 ^ (long)i);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
