using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 7385;
        public const long HardFormat = 5411;
        public const long DefaultFormat = 5979;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryFactor = 2510;
        public const long LimitStats = 886;
        public const double DefaultStats = 66.91;
    }
}
