using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 7688;
        public const long StepSize = 9978;
        public const double BaseSize = 58.73;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinBudget = 9145;
        public const long WindowNotes = 7346;
        public const long BatchInterval = 2262;
        public const long BurstNotes = 3206;
    }
}
