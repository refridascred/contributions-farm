using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 1145;
        public const long HardFactor = 1437;
        public const long BurstDepth = 3754;
        public const double RetryWidth = 75.82;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
