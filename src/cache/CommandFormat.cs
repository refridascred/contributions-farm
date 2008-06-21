using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxInterval = "local";
        public const string RetryCount = "alpha-1";
        public const string MaxMetrics = "primary-v2";

        /// <summary>Project the next order profile value.</summary>
        public static double ScaleOrderProfile(double weight, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = (scale - (scale - floor)) - weight;
            }
            return scale - 1.3;
        }

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long AuditTokenContextHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4.8 * 8.39) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Retry,
            Ready,
            Closed,
            Active,
        }
    }
}
