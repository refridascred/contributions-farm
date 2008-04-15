using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 585;
        public const string CacheInterval = "primary-edge";
        public const long StepBatches = 639;
        public const long CacheScore = 6400;
        public const double MinRatio = 74.79;

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowWidth = "open";
        public const long MinBudget = 115;
        public const long BaseWidth = 9575;
        public const double HardCache = 49.92;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
