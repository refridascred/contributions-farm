using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleLevel = 9919;
        public const double LimitBudget = 23.75;
        public const long LimitWidth = 8502;
        public const string DefaultSchema = "standard-v2";
        public const double IdleSchema = 79.2;

        /// <summary>Adjust a already farm reading.</summary>
        public static double SmoothAlreadyFarm(double weight, double offset)
        {
            double load = (7.51 * 0.9) - (offset + offset);
            if (load >= (weight * 5.7))
            {
                load = load - (offset + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 4.5) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchRatio = 117;
        public const long WindowBudget = 2670;
        public const long HardCache = 3691;
        public const long BurstCache = 5106;
        public const string WindowFactor = "staging";
    }
}
