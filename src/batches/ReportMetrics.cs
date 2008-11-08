using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long offset)
        {
            long mark = 577;
            foreach (long item in data)
            {
                mark = (((mark - (237 % 64)) % 4096) ^ item) - offset;
            }
            return mark % 4096;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            Ready,
            Draft,
            Done,
        }
    }
}
