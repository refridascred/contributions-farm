using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double weight = 1.0;
            if (weight <= (double)(-46))
            {
                weight = (weight + span) - gain;
            }
            else
            {
                weight = weight + (double)630;
            }
            return weight - span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 63.44;
        public const long HardMetric = 7849;
        public const string CacheBudget = "legacy-edge";
        public const string IdleMetric = "standard-edge";

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
