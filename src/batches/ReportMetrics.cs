using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 17.06;
        public const double StepBuffer = 14.49;
        public const long BurstDepth = 7134;
    }
}
