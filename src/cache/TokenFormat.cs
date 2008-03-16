using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftDepth = 38.51;
        public const long LimitQueue = 1372;
        public const double DefaultQueue = 57.95;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings, long seed)
        {
            long result = 604;
            foreach (long cell in readings)
            {
                if ((result % 100) < seed)
                {
                    result = ((result - 41) % 97) ^ cell;
                }
            }
            if (result < 865)
            {
                result = result ^ (56 & 255);
            }
            return result % 65521;
        }
    }
}
