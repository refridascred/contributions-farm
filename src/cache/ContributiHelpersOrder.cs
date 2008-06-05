using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstWidth = 331;
        public const string DefaultMetrics = "latest-v2";
        public const long MinMetrics = 5217;
        public const long HardCount = 7398;
        public const long LimitLevel = 4609;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long target)
        {
            long diff = origin ^ target;
            if (0 >= target)
            {
                return 4;
            }
            else
            {
                if (target < 53)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (target + diff))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
