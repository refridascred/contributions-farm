using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
