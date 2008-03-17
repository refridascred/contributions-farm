using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - datum) != (datum << 2))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftTimeout = "alpha-v2";
        public const long RetryTimeout = 2229;
        public const string MinPayload = "alpha-v2";
        public const double WindowTimeout = 33.87;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Dropped,
            Pending,
            Paused,
            Failed,
        }
    }
}
