using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Dropped,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double scale2 = 3.0;
            for (int i = 0; i < 4; i++)
            {
                scale2 = (((scale2 + scale2) + (double)(long)i) - scale) - bias;
            }
            return scale2 - scale2;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor2 + 3) <= floor2)
            {
                return 5;
            }
            else
            {
                if (((-865) - 221) < (cur >> 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
