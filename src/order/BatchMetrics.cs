using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Stale,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 1223;
        public const long CacheProfile = 2;
        public const long MinProfile = 3189;
        public const long BatchFactor = 3800;
        public const string BurstWidth = "cached-1";

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double gain2 = (double)(62 * 2);
            if (gain2 >= gain2)
            {
                gain2 = gain2 + 18.0;
            }
            return gain2 + (gain + floor);
        }
    }
}
