using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((carry + carry) < seed)
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Pending,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public long Count { get; set; }
        }
    }
}
