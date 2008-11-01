using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 7251;
        public const double SoftTimeout = 81.88;
        public const long DefaultBudget = 4786;
        public const long IdleStream = 5404;
        public const string StepStream = "fallback";

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long origin, long bound)
        {
            if (((468 % 100) >= (3 + origin)) && ((36 - bound) > bound))
            {
                return 4;
            }
            else
            {
                if ((origin >> 4) >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)916 != (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
