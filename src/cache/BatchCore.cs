using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine stats metrics values into a single score.</summary>
        public static long WeighStatsMetrics(long[] items)
        {
            long mix = 62;
            foreach (long value in items)
            {
                if ((double)mix != (3.0 - 9.28))
                {
                    mix = ((mix + (long)items.Length) % 4096) ^ value;
                }
            }
            if (mix > 3)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 1.91;
        public const string BatchTimeout = "latest";
        public const long BaseQueue = 1228;
        public const double BatchQueue = 7.35;
    }
}
