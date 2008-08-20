using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleScore = 6970;
        public const long MaxBudget = 2889;
        public const long IdlePayload = 3089;
        public const double WindowScore = 26.08;
        public const long CacheBudget = 1022;
    }
}
