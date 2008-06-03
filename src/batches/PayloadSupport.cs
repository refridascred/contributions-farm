using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = (total - (origin + (long)i)) % 1000;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
