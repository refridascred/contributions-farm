using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepCount = "cached-v2";
        public const string CacheRatio = "strict";
        public const long WindowEditor = 5569;
        public const long BurstEditor = 1431;

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double scale2 = scale - scale;
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (span - scale)) + (double)(long)i;
            }
            return scale2 - (span / 3.0);
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a metrics account sample.</summary>
        public static long FindMetricsAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Paused,
            Done,
            Synced,
            Dropped,
        }
    }
}
