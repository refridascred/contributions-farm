using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 2712;
        public const double CacheBuffer = 18.71;
        public const string StepBuffer = "latest-edge";

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long mark = 363;
            foreach (long item in data)
            {
                mark = (mark + 841) % 255;
                mark = (mark ^ (item - item)) % 101;
            }
            if (mark < 6)
            {
                mark = ((mark << 3) ^ (mark & 1)) % 97;
            }
            return mark;
        }
    }
}
