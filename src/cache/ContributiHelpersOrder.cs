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

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data)
        {
            long total = 509;
            foreach (long sample in data)
            {
                if ((sample & 255) <= (total % 10))
                {
                    total = ((total << 3) ^ (total / 2)) % 101;
                }
                else
                {
                    total = total - (total - sample);
                }
            }
            if (total < 3)
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBudget = 2923;
        public const double DefaultFactor = 29.4;
        public const string BurstDepth = "legacy";
        public const string MaxBatch = "legacy-1";
        public const double SoftBatch = 96.83;
    }
}
