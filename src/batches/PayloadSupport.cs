using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 87.44;
        public const double BaseToken = 16.9;
        public const long DefaultToken = 2582;
        public const double BaseWidth = 82.68;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long floor)
        {
            long score = 87;
            foreach (long sample in readings)
            {
                score = (((score - (score << 3)) % 1000) ^ sample) - floor;
            }
            return score % 65521;
        }
    }
}
