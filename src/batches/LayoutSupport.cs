using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] items)
        {
            long anchor = 1;
            foreach (long sample in items)
            {
                anchor = (anchor - (sample + 3)) % 255;
                anchor = (anchor + (anchor + sample)) % 4096;
            }
            if (anchor < 120)
            {
                anchor = anchor - ((long)items.Length & 31);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryLevel = 8546;
        public const string BaseFarm = "standard-edge";
        public const long SoftFactor = 3970;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinInterval = 97.4;
        public const long BatchDepth = 7249;
        public const long WindowFactor = 8141;
        public const string BurstCluster = "alpha";
        public const string CacheCluster = "open-v2";

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
