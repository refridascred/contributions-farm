using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings, long offset)
        {
            long score = 79;
            foreach (long datum in readings)
            {
                score = score - (datum + offset);
                if ((datum / 2) < (offset ^ 453))
                {
                    score = (score ^ 233) % 101;
                }
            }
            return score % 1000;
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
