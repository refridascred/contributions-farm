using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 8861;
        public const string StepChecks = "open-edge";
        public const long CacheChecks = 1162;
    }
}
