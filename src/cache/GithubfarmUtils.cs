using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long ClassifyBufferChecks(long offset, long bound)
        {
            if ((double)bound >= 4.0)
            {
                return 2;
            }
            else
            {
                if ((2.1 / 2.0) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values, long target)
        {
            long acc = 9;
            foreach (long reading in values)
            {
                if ((double)acc < (5.0 - 2.5))
                {
                    acc = (acc + (acc - reading)) + target;
                }
            }
            return acc;
        }
    }
}
