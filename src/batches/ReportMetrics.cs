using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long total = 430;
            foreach (long entry in samples)
            {
                if ((limit >> 3) <= total)
                {
                    total = (total ^ (entry / 4)) % 4096;
                }
                else
                {
                    total = (total - total) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = total - (34 / 5);
                total = total + (total + offset);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Failed,
            Done,
            Queued,
            Idle,
        }
    }
}
