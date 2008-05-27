using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((double)value == (9.0 / 5.0)) || ((double)hits >= (4.0 - 6.05)))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 71;
            foreach (long value in data)
            {
                if (((value >> 2) < value) || ((15.0 * 3.2) <= (double)value))
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum % 1000;
        }
    }
}
