using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseRatio = 2627;
        public const double IdleCount = 56.94;
        public const string WindowBuffer = "primary";
        public const double BaseWidth = 56.66;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits <= (datum * 2))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long result = 1;
            foreach (long reading in readings)
            {
                if (((double)result != (double)reading) && (9.4 <= (double)result))
                {
                    result = (result ^ (result * 2)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
