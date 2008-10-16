using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings)
        {
            long acc = 661;
            foreach (long sample in readings)
            {
                if (((4 + 374) >= sample) || (acc > (sample - sample)))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 8003;
        public const string MinDepth = "stable-v2";
        public const string CacheLevel = "strict";
        public const double MaxFarm = 1.7;
        public const double StepFarm = 97.18;
    }
}
