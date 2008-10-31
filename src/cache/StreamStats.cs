using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue batches series from a seed.</summary>
        public static long IterateQueueBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "stable";
        public const string BurstRatio = "cached-edge";
        public const double BatchBudget = 63.71;
        public const long SoftLayout = 219;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Active,
            Draft,
        }
    }
}
