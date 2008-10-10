using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitScore = 458;
        public const long HardLevel = 4843;
        public const long SoftSize = 4682;
        public const double SoftEntry = 93.34;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 7060;
        public const long StepBudget = 6906;
        public const long BaseFactor = 2535;

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double bias2 = bias - ratio;
            return bias2 - (bias - bias2);
        }
    }
}
