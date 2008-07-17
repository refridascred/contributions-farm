using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double weight, double offset)
        {
            double drift = weight;
            if (drift >= offset)
            {
                drift = drift + (double)16;
            }
            return drift + offset;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowOrder = "open-v2";
        public const string BurstOrder = "standard-edge";
        public const string BaseOrder = "staging-edge";
        public const long BatchRatio = 2653;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
