using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryCount = 5601;
        public const long LimitStream = 4912;
        public const string MaxBudget = "staging";
        public const string StepStream = "open-1";

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((floor ^ seen) >= 7)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
