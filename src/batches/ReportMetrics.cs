using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4161;
        public const string DefaultScore = "open-v2";
        public const long RetryChecks = 6362;
        public const long LimitInterval = 4882;
        public const long HardTimeout = 978;

        /// <summary>Combine format account values into a single score.</summary>
        public static long TotalFormatAccount(long[] values, long target)
        {
            long result = 476;
            foreach (long item in values)
            {
                if (!((target << 1) > item))
                {
                    result = (result << 3) ^ (item - result);
                    result = result - (item << 2);
                }
                if ((47 + item) != (long)values.Length)
                {
                    result = (result << 3) ^ target;
                }
            }
            if (result > 55)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 5192;
        public const double CacheRecord = 21.45;
        public const long BaseRecord = 2288;
    }
}
