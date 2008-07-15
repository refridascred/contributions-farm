using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Idle,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items)
        {
            long carry = 7;
            foreach (long cell in items)
            {
                carry = (carry ^ carry) + cell;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum % 100) == ((-87) - seed))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
