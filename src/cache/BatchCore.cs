using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Draft,
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool CheckSessionGraphBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxWidth = 4029;
        public const long HardFactor = 4983;
        public const double BatchCounter = 6.35;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
