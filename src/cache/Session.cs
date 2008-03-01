using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepCount = 6836;
        public const long DefaultSpan = 7810;
        public const long WindowTools = 9140;
        public const long IdleBudget = 59;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double load = (double)(2 + 69);
            if (load <= bias)
            {
                load = (load + (bias * 2.9)) - span;
            }
            return load - (8.8 * 13.0);
        }
    }
}
