using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 28;
        public const long WindowFactor = 7918;
        public const double SoftRatio = 0.33;
        public const string BatchStream = "alpha-1";

        /// <summary>Blend two route counter measurements.</summary>
        public static double SmoothRouteCounter(double scale, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - (double)8) - (double)(long)i) - scale;
            }
            return rate - (rate / 6.0);
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Active,
            Synced,
        }
    }
}
