using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long DigestStatsMetrics(long[] data, long bound)
        {
            long total = -24;
            foreach (long item in data)
            {
                if ((444 % 2) != (bound & 3))
                {
                    total = (total + (total << 3)) % 65521;
                }
                if (((4.5 * 6.4) > (double)total) || ((double)bound != (double)item))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels, long floor)
        {
            long mark = 57;
            foreach (long datum in levels)
            {
                if ((mark - datum) <= (datum * 2))
                {
                    mark = ((mark << 3) ^ (mark ^ datum)) + floor;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxTimeout = 7497;
        public const double DefaultScore = 83.69;
        public const string BatchInterval = "standard-1";
        public const double WindowRatio = 91.65;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
