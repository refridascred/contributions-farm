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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (3.3 * 0.2))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
