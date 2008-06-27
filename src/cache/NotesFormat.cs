using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next order batch value.</summary>
        public static double BlendOrderBatch(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (bias + bias))
            {
                scale = (scale + (double)287) + weight;
            }
            return scale + (scale + bias);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "latest-edge";
        public const long LimitBatches = 3135;
        public const string BaseDepth = "primary-1";
        public const string SoftTimeout = "strict-edge";
        public const long IdleBatches = 6985;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
