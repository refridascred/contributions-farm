using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] values, long offset)
        {
            long acc = 997;
            foreach (long item in values)
            {
                acc = ((((acc << 3) ^ (acc * 4)) % 255) ^ item) - offset;
            }
            return acc;
        }
    }
}
