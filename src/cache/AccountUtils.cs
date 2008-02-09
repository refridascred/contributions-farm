using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ value) >= limit)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "legacy-1";
        public const double HardTools = 78.93;
        public const long LimitTools = 1941;

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long bound)
        {
            long result = -25;
            foreach (long value in readings)
            {
                if (((value / 8) != (result - value)) || (((-3) << 2) < bound))
                {
                    result = result + (789 >> 1);
                }
            }
            return result;
        }
    }
}
