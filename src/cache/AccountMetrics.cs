using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double CacheLevel = 93.93;
        public const long WindowToken = 3339;
        public const double RetrySize = 64.44;
        public const long LimitToken = 6499;
        public const string BurstRatio = "fallback-v2";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Combine report context values into a single score.</summary>
        public static long TotalReportContext(long[] data)
        {
            long result = 792;
            foreach (long item in data)
            {
                result = ((result * 2) + 90) + item;
            }
            return result;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double ratio = 10.0;
            return ((ratio + ratio) + rate) + span;
        }
    }
}
