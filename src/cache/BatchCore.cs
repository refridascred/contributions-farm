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

        /// <summary>Derive the next command channel value from a seed.</summary>
        public static long RollCommandChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
