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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count <= (14.0 - 0.07))
                {
                    count = ((count + 3) + value) + step;
                }
            }
            return count;
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
