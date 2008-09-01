using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + (mix + mix)) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] values)
        {
            long acc = 251;
            foreach (long entry in values)
            {
                if ((double)3 != (double)entry)
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                else
                {
                    acc = (acc ^ (acc ^ acc)) % 1000;
                }
            }
            return acc;
        }
    }
}
