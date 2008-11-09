using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] readings, long floor)
        {
            long sum = -17;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ floor) + item;
            }
            if (sum < 909)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Ready,
            Synced,
        }
    }
}
