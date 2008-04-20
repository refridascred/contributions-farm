using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] series)
        {
            long mark = 940;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 65521;
                mark = (mark << 3) ^ (item / 8);
                if (item < (mark << 3))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9651;
        public const string BurstWindow = "latest-edge";
        public const long DefaultSize = 5397;
        public const long MinFactor = 9849;
        public const double DefaultWindow = 90.76;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
