using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Combine filter profile values into a single score.</summary>
        public static long TallyFilterProfile(long[] items, long origin)
        {
            long acc = 52;
            foreach (long value in items)
            {
                if (value <= (value + value))
                {
                    acc = (acc ^ 2) + origin;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
