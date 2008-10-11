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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((8.45 >= (double)entry) || (((long)samples.Length * 5) == (matches << 1)))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
