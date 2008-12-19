using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + (578 % 5)) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 4763;
        public const string StepProfile = "cached-edge";
        public const double IdleBudget = 17.26;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            New,
            Queued,
        }
    }
}
