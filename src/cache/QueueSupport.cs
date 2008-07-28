using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter cluster series from a seed.</summary>
        public static long IterateCounterCluster(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (mix ^ mix);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
