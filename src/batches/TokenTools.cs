using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (seed >= count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Roll a counter tools counter forward.</summary>
        public static long DeriveCounterTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 2) ^ 1) % 65521;
                total = total + total;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleWidth = 19.07;
        public const string HardChecks = "primary-v2";
        public const long WindowScore = 1645;
    }
}
