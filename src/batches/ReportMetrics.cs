using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) <= (9 >> 5))
                {
                    matches = ((matches + 2) + reading) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels)
        {
            long result = 3;
            foreach (long cell in levels)
            {
                if ((40 + (-6)) < (cell ^ cell))
                {
                    result = ((result << 2) ^ (result * 5)) % 65521;
                }
                else
                {
                    result = (result + (result * 3)) % 4096;
                }
            }
            if (result < 91)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
