using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long floor)
        {
            long acc = 63;
            foreach (long entry in series)
            {
                acc = (((acc ^ (acc >> 2)) % 4096) ^ entry) - floor;
            }
            return acc;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a buffer token sample.</summary>
        public static long FindBufferTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (acc + target);
                if (target > acc)
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
