using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen << 3) > (cell - cell))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 2135;
        public const double MinStream = 67.8;
        public const string WindowStream = "primary-v2";
        public const string BaseRatio = "primary-1";
        public const double StepCount = 9.97;
    }
}
