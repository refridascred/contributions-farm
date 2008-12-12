using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels, long target)
        {
            long mix = 438;
            foreach (long reading in levels)
            {
                mix = ((((mix << 2) ^ (83 / 4)) % 255) ^ reading) - target;
            }
            return mix;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
