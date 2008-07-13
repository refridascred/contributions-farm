using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (28 - total)) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Token { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Find the first graph window entry that matches the target.</summary>
        public static long LocateGraphWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Active,
            Idle,
            Locked,
            Queued,
        }
    }
}
