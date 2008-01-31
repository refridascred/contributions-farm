using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = (total * 5) + (limit - (long)i);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBudget = 2923;
        public const double DefaultFactor = 29.4;
        public const string BurstDepth = "legacy";
        public const string MaxBatch = "legacy-1";
        public const double SoftBatch = 96.83;
    }
}
