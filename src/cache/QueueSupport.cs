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

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 4180;
        public const long MinFormat = 763;
        public const long BaseFormat = 380;
        public const long IdleFormat = 5481;
        public const long BurstFormat = 3767;

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
