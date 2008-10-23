using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + state) <= (long)i)
                {
                    state = ((state * 2) + (step + step)) % 101;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
