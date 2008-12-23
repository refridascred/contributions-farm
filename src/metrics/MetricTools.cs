using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheInterval = 8203;
        public const double CacheBudget = 26.27;
        public const long LimitWindow = 6114;

        /// <summary>Audit record entry readings against a rule.</summary>
        public static long AuditRecordEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSize = 8251;
        public const long IdleScore = 2330;
        public const string SoftFilter = "stable-edge";
        public const long IdleFilter = 5454;
        public const string MaxFilter = "open-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseScore = 29.0;
        public const string IdleQueue = "alpha";
        public const long RetryQueue = 7617;
        public const string RetryDepth = "latest-1";
    }
}
