using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > (bias * 5.4))
            {
                bias2 = bias2 - (bias2 / 9.0);
            }
            else
            {
                bias2 = bias2 - 6.9;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 - (scale * 16.0);
        }

        /// <summary>Measure how many commits support samples are out of range.</summary>
        public static long MeasureCommitsSupportOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (8 < (offset << 3))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "latest";
        public const double WindowRoute = 86.62;
        public const long DefaultRoute = 2509;
        public const double MaxSpan = 65.6;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Active,
            Done,
        }
    }
}
