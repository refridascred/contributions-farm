using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Ready,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "stable";
        public const string BatchStream = "stable-v2";
        public const long SoftStream = 2509;
        public const long HardSpan = 3577;

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRatio = 2966;
        public const long BatchDepth = 3722;
        public const double LimitRoute = 33.42;

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double drift = weight;
            if (drift > offset)
            {
                drift = drift + (offset / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)400;
        }
    }
}
