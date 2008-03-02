using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix << 3) ^ bound) % 1000;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 9929;
        public const long IdleSpan = 2040;
        public const string LimitScore = "strict-edge";
        public const long MinScore = 7723;
        public const double WindowSpan = 88.76;
    }
}
