using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "alpha-v2";
        public const long MinTimeout = 7775;
        public const string MaxSpan = "primary-v2";
        public const double SoftMetrics = 16.51;

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 3076;
        public const long BurstStats = 7504;
        public const long MinScore = 9556;
        public const long SoftCount = 1514;
        public const long RetryBudget = 9436;
    }
}
