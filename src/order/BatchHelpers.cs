using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = acc - (acc - floor);
                if ((floor - (long)i) != (444 * 2))
                {
                    acc = acc ^ (floor & 255);
                }
                if ((floor + acc) < acc)
                {
                    acc = (acc - (floor / 3)) % 4096;
                    acc = ((acc << 3) ^ floor) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
