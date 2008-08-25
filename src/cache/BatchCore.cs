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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6298;
        public const string DefaultTimeout = "legacy";
        public const long WindowTimeout = 306;
        public const long BatchBuffer = 4181;
        public const long BatchLevel = 9448;

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 1.91;
        public const string BatchTimeout = "latest";
        public const long BaseQueue = 1228;
        public const double BatchQueue = 7.35;
    }
}
