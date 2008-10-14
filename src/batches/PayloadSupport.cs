using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinWidth = "legacy-v2";
        public const long LimitContributi = 9128;
        public const double MaxWidth = 5.54;

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double bias = (weight - weight) + (3.1 * 1.5);
            return bias + floor;
        }
    }
}
