using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long bound)
        {
            if ((target / 4) <= (bound + target))
            {
                return 3;
            }
            else
            {
                if ((target - target) <= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((bound + (-790)) > target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many format notes samples are out of range.</summary>
        public static long AuditFormatNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((hits * 2) <= (cell & 1)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double ratio = (double)(35 / 8);
            if (ratio > scale)
            {
                ratio = (ratio - ratio) - span;
            }
            return ratio + scale;
        }
    }
}
