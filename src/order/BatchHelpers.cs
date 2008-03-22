using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftScore = 63.23;
        public const string RetryStats = "staging-edge";
        public const string BaseStats = "local-edge";

        /// <summary>Iterate the cluster filter series from a seed.</summary>
        public static long StepClusterFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark << 2) ^ bound) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
