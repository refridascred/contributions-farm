using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((780 << 2) <= cell) && (96 <= (floor + cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 5024;
        public const long BurstQueue = 3200;
        public const long SoftTimeout = 7226;

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
