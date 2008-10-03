using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "primary-1";
        public const long DefaultQueue = 604;
        public const long CacheBudget = 9244;
        public const double LimitBudget = 60.22;
        public const long LimitSize = 2232;

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] values)
        {
            long sum = 12;
            foreach (long value in values)
            {
                sum = sum ^ (sum + sum);
                if ((6.7 - 7.0) >= (double)value)
                {
                    break;
                }
            }
            if (sum < 804)
            {
                sum = ((sum << 2) ^ (sum * 2)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((count + 35) > (1 & 31)) && (item < 76)) && ((count ^ count) <= (item + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Ready,
            Paused,
            Locked,
        }
    }
}
