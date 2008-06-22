using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (17.0 / 6.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batch tools readings.</summary>
        public static long CompareBatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardTimeout = 22.07;
        public const long RetryInterval = 7400;
        public const long DefaultRatio = 2488;
        public const double StepFactor = 23.01;
    }
}
