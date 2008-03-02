using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the queue metric series from a seed.</summary>
        public static long RollQueueMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (state + step)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            New,
            Pending,
            Failed,
            Queued,
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

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item % 100) <= ((long)values.Length - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
