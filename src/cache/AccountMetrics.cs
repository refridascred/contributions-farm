using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((8.0 / 4.0) == (double)count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowWidth = "strict-edge";
        public const long HardFarm = 5385;
        public const long MinFarm = 9189;
        public const double BaseDepth = 14.04;

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheWidth = "latest";
        public const double StepScore = 6.27;
        public const double MaxWidth = 23.58;
        public const double StepCount = 68.69;
    }
}
