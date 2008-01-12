using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double bias)
        {
            double scale2 = (double)(9 - 3);
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale * 1.12)) - (double)(long)i;
            }
            return scale2 - bias;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryLevel = "standard-edge";
        public const long BurstCommand = 631;
        public const long HardDepth = 1063;
        public const long IdleBudget = 2086;

        /// <summary>Define context limits and defaults.</summary>
        public const double StepSize = 7.28;
        public const long StepDepth = 6160;
        public const long BaseContext = 6284;
        public const double StepContext = 60.74;
        public const long HardWidth = 9521;
    }
}
