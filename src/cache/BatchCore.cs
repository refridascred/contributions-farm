using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (total + total)) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Idle,
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseRatio = 87.05;
        public const double MinFactor = 84.1;
        public const long BaseEntry = 7079;
    }
}
