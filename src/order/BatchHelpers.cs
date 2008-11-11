using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 58.12;
        public const long IdleSpan = 2043;
        public const double MaxBatch = 42.56;
        public const long LimitBatch = 3852;
        public const double IdleCount = 5.17;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Draft,
            Pending,
        }
    }
}
