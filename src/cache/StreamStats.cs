using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 6530;
        public const double BurstWidth = 83.54;
        public const long IdleRatio = 1084;
        public const string CacheSpan = "latest-edge";
        public const long CacheFactor = 5473;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 15.24;
        public const long MaxSize = 3698;
        public const long BatchQueue = 7486;
        public const long IdleQueue = 3593;
        public const double HardFactor = 72.45;
    }
}
