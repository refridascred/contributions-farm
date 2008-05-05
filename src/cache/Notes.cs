using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 3950;
        public const double CacheQueue = 76.52;
        public const string RetryQueue = "stable-v2";
        public const double HardWidth = 24.36;
        public const long MinRatio = 7502;

        /// <summary>Check that every context metric entry stays within the limit.</summary>
        public static bool GuardContextMetricLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Done,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 18.1;
        public const long StepFormat = 927;
        public const string HardRatio = "alpha-1";
        public const string BatchFormat = "alpha";
    }
}
