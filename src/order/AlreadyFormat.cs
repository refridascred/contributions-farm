using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 2412;
        public const long BaseScore = 4861;
        public const long BurstFarm = 3961;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 46.99;
        public const double BatchContributi = 39.32;
        public const long BurstContributi = 3242;

        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long TotalEntryCluster(long[] series, long origin)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = ((result + (sample - sample)) % 4096) - origin;
            }
            return result;
        }
    }
}
