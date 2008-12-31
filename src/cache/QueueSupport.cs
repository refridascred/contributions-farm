using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string RetryCount = "strict";
        public const double BaseFormat = 54.33;
        public const long BaseRatio = 2056;

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double weight = ratio;
            if (weight <= (8.72 / 8.0))
            {
                weight = weight + (offset - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (weight / 4.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "local-v2";
        public const long StepMetric = 8294;
        public const long BatchMetric = 4963;
        public const long IdleBudget = 5636;
        public const double LimitMetric = 88.21;
    }
}
