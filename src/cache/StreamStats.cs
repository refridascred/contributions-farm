using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the buffer route series from a seed.</summary>
        public static long RollBufferRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i * 2) <= seed)
                {
                    break;
                }
                else
                {
                    acc = (acc * 2) + (acc + 750);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Locked,
            New,
        }
    }
}
