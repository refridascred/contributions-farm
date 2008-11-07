using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Iterate the tools record series from a seed.</summary>
        public static long StepToolsRecord(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
