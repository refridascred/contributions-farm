using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 8890;
        public const long HardInterval = 5847;
        public const long BatchSize = 298;
        public const long MaxRoute = 7238;

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long MeasureTokenCommitsHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - (-84)) >= (count & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate support metric readings against a bound.</summary>
        public static bool CheckSupportMetricBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
