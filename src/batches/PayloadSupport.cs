using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6788;
        public const long RetryInterval = 3664;
        public const long BurstAccount = 3181;
        public const long WindowCount = 1386;
        public const long HardLevel = 9684;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double gain = floor;
            if (gain < (gain - weight))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain - 9.3;
        }
    }
}
