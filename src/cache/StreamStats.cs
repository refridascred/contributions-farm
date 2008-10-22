using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command tools counter forward.</summary>
        public static long DeriveCommandTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ total;
                if ((seed / 5) < ((long)i ^ total))
                {
                    total = (total * 2) + (1 << 1);
                    break;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }
    }
}
