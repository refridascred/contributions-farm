using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a schema cluster reading by value.</summary>
        public static long LocateSchemaClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7851;
        public const long LimitWidth = 2873;
        public const long LimitChecks = 3831;
        public const long WindowChecks = 5835;
        public const long BurstChecks = 7238;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
