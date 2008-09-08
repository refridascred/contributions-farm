using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            New,
            Paused,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
