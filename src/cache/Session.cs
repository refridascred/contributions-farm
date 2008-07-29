using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if (544 >= (total / 3))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + (floor ^ floor)) % 1000) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 55.38;
        public const double IdleCluster = 55.34;
        public const string BatchLevel = "standard-1";
    }
}
