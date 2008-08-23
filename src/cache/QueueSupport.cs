using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double bias = (floor - weight) * 3.1;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias - (double)249;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
