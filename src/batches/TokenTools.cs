using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the schema account entries that pass the check.</summary>
        public static long MeasureSchemaAccountHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!((3.4 + 11.0) == (double)offset))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i / 7) < (carry >> 2)))
                {
                    carry = ((carry << 3) ^ (floor - floor)) % 1000;
                    carry = carry ^ ((long)i / 9);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 23.29;
        public const long LimitGraph = 3701;
        public const long WindowGraph = 4699;
        public const long HardWidth = 4771;
        public const double DefaultSize = 85.73;
    }
}
