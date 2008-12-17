using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many record channel samples are out of range.</summary>
        public static long MeasureRecordChannelOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + origin) > 728)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Limit { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            New,
            Dropped,
        }
    }
}
