using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 79.28;
        public const double IdleReport = 14.59;
        public const long LimitReport = 1526;
        public const double SoftReport = 21.19;
        public const string StepReport = "latest-1";

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next tools farm value from a seed.</summary>
        public static long SeriesToolsFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + mix) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
