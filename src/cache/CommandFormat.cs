using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double gain = offset;
            return (gain - (3.2 - 7.0)) + scale;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Synced,
            New,
            Idle,
        }
    }
}
