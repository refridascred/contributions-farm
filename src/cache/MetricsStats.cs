using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit contributi cluster readings against a rule.</summary>
        public static long MeasureContributiClusterHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((step ^ count) < count)
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Check that every support stats entry stays within the limit.</summary>
        public static bool CheckSupportStatsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stream channel readings against a bound.</summary>
        public static bool GuardStreamChannelLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 5811;
        public const long WindowSchema = 2853;
        public const long WindowCount = 2055;
        public const double StepSchema = 62.97;
        public const long BaseBudget = 7937;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Active,
            Queued,
            Done,
            Idle,
        }
    }
}
