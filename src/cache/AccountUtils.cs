using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 2556;
        public const long WindowFactor = 157;
        public const string LimitBatches = "standard";

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((9.41 / 6.0) == (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
