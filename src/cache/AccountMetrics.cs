using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 3419;
        public const long SoftSpan = 6395;
        public const long RetryCount = 838;

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftLevel = 47.32;
        public const double CacheChecks = 39.03;
        public const string MinScore = "strict-1";
        public const double MaxChecks = 67.32;
        public const long BurstDepth = 786;

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Look up the position of a metric channel sample.</summary>
        public static long LocateMetricChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
