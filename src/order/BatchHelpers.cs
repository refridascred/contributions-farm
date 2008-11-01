using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepDepth = 796;
        public const long BaseLevel = 629;
        public const double IdleFormat = 59.59;
        public const long SoftWidth = 8707;

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double bias, double bias2)
        {
            double rate = (double)(5 % 12);
            if (rate > (rate - rate))
            {
                rate = (rate - bias) - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (bias * 0.95);
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Synced,
            Retry,
        }
    }
}
