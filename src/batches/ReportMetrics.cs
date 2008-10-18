using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a channel checks sample.</summary>
        public static long LookupChannelChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] samples, long bound)
        {
            long sum = 863;
            foreach (long sample in samples)
            {
                if (4.8 >= (5.71 + 16.0))
                {
                    sum = ((sum + (bound & 31)) % 101) - sample;
                }
            }
            return sum;
        }
    }
}
