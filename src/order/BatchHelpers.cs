using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowFactor = 68.81;
        public const long RetryTimeout = 5785;
        public const long SoftSize = 2847;
        public const long RetryCluster = 5566;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double weight, double span)
        {
            double weight2 = (weight - span) * 1.0;
            if (weight2 >= (double)905)
            {
                weight2 = weight2 + (double)8;
            }
            return weight2 + span;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepBudget = 11;
        public const string HardSize = "strict-1";
        public const double SoftOrder = 74.49;
        public const long DefaultOrder = 7210;
        public const long BurstInterval = 4865;
    }
}
