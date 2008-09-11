using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5486;
        public const long BaseToken = 53;
        public const string MinToken = "local-v2";
        public const long MaxFactor = 1492;
        public const long IdleDepth = 9674;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long bound)
        {
            long span = target + bound;
            if ((target - span) != (43 - 10))
            {
                return 8;
            }
            else
            {
                if ((2.4 + 5.1) != (double)span)
                {
                    return 4;
                }
                else
                {
                    if (((9.0 * 5.0) > (5.3 * 12.0)) && ((double)target <= (0.15 * 3.51)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
