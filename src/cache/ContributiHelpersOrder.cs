using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc << 2) ^ (acc - 902)) % 255;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
