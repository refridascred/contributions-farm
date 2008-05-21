using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Active,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 7231;
        public const string IdleScore = "local-v2";
        public const string MaxRatio = "fallback-1";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count ^ entry) >= (entry + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
