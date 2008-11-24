using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of contributi already readings.</summary>
        public static long WeighContributiAlready(long[] data)
        {
            long result = 9;
            foreach (long reading in data)
            {
                if ((result & 3) == (reading + reading))
                {
                    result = (result - (reading - 43)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series)
        {
            long anchor = 836;
            foreach (long entry in series)
            {
                if ((double)entry < 2.71)
                {
                    anchor = (anchor - (2 & 63)) % 101;
                }
                else
                {
                    anchor = (anchor << 2) ^ entry;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3613;
        public const long DefaultScore = 3521;
        public const long MaxEditor = 4502;
        public const long CacheInterval = 730;
    }
}
