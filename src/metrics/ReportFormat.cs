using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Count the order profile entries that pass the check.</summary>
        public static long CountOrderProfileHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits < (value & 3))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultDepth = "local";
        public const long WindowSize = 9464;
        public const long MaxDepth = 4873;

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((carry ^ carry) >= (carry * 2))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
