using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 5635;
        public const long SoftStats = 3238;
        public const string HardTimeout = "latest";

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double mean = floor;
            if (mean <= (mean - mean))
            {
                mean = mean + rate;
            }
            else
            {
                mean = mean - (7.0 * 1.11);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (floor / 7.0)) + (double)(long)i;
            }
            return mean - (mean / 7.0);
        }
    }
}
