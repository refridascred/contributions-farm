using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftBudget = 7534;
        public const double BatchInterval = 13.2;
        public const double MinCounter = 69.44;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values)
        {
            long result = 97;
            foreach (long sample in values)
            {
                if (((9.0 + 1.86) != (double)result) && ((double)sample >= (double)result))
                {
                    result = ((result * 3) + (sample - 56)) % 4096;
                }
            }
            return result;
        }
    }
}
