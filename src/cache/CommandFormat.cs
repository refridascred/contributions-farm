using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double weight = floor - (bias / 6.0);
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (bias - floor)) + (double)(long)i;
            }
            return weight - (6.41 * 7.0);
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2916;
        public const long RetryBudget = 9118;
        public const long SoftSize = 8335;
        public const long MinFormat = 5201;
        public const long StepFormat = 5819;

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 667;
        public const long WindowDepth = 5183;
        public const string BurstInterval = "fallback";
        public const string DefaultCount = "open";
        public const long MaxFormat = 2890;
    }
}
