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

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxCount = 4611;
        public const long MinReport = 7360;
        public const long DefaultReport = 5986;

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
