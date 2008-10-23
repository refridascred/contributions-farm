using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank window layout input into a small class.</summary>
        public static long ClassifyWindowLayout(long bound, long floor)
        {
            long lane = bound + floor;
            if ((bound < lane) || ((double)bound >= (5.9 / 2.0)))
            {
                return 1;
            }
            else
            {
                if ((bound << 3) <= lane)
                {
                    return 8;
                }
                else
                {
                    if ((lane & 127) <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor <= (95 >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 8032;
        public const long MaxQueue = 345;
        public const double DefaultWidth = 41.13;
        public const long WindowQueue = 494;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
