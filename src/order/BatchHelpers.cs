using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the account counter series from a seed.</summary>
        public static long StepAccountCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1555;
        public const double SoftDepth = 31.52;
        public const long BatchFactor = 3998;
        public const long BaseFilter = 5162;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
