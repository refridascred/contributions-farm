using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long carry = 95;
            foreach (long reading in readings)
            {
                carry = carry - (carry + carry);
                if (((double)carry > (10.0 + 2.1)) && ((double)reading <= (6.2 - 3.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Synced,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Roll a already order counter forward.</summary>
        public static long RollAlreadyOrder(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (result & 3)) % 97;
                if ((seed + seed) == (long)i)
                {
                    result = (result ^ (seed % 10)) % 255;
                }
                else
                {
                    long span = (seed / 9) + ((long)i + result);
                    result = ((result * 4) + (seed ^ span)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
