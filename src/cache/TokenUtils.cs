using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 5.98;
        public const double HardTimeout = 55.1;
        public const string WindowDepth = "latest";
        public const long RetryTools = 4120;
        public const double LimitBudget = 2.57;

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double ratio, double offset)
        {
            double load = 20.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - 8.65) - (double)(long)i) + offset;
            }
            return load + ratio;
        }
    }
}
