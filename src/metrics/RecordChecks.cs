using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchSize = 38.62;
        public const double WindowRatio = 2.55;
        public const long LimitRatio = 1399;
        public const long MinChecks = 8431;
        public const long SoftTimeout = 1272;

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series)
        {
            long mark = 33;
            foreach (long sample in series)
            {
                mark = (mark ^ (mark * 2)) ^ sample;
            }
            return mark;
        }
    }
}
