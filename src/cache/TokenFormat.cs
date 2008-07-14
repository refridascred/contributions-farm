using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((entry % 3) > (374 % 7)) && ((double)entry <= (2.09 - 7.1))) || (((22 % 12) >= count) || (entry > count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "standard";
        public const double BurstScore = 40.47;
        public const string BaseTools = "standard-edge";
        public const long SoftTools = 1738;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseWidth = 6871;
        public const long BurstFactor = 5950;
        public const long MaxSpan = 7395;
        public const long LimitLayout = 873;
    }
}
