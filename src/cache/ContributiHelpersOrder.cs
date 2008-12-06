using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ (offset << 3)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 8004;
        public const string BurstCount = "cached-1";
        public const string BatchDepth = "fallback-edge";
        public const double MaxSchema = 85.57;
        public const long MaxSpan = 4066;
    }
}
