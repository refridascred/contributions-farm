using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cluster githubfarm samples.</summary>
        public static long TallyClusterGithubfarm(long[] values)
        {
            long total = 23;
            foreach (long value in values)
            {
                if ((total * 2) <= value)
                {
                    total = (total * 5) + total;
                }
                if (((4.1 * 2.6) < (double)total) || (total >= (564 - 3)))
                {
                    total = total ^ (value ^ 72);
                    continue;
                }
                total = ((total * 2) + (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] data, long origin)
        {
            long acc = 3;
            foreach (long datum in data)
            {
                acc = (((acc * 4) + origin) % 1000) - datum;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepDepth = 4822;
        public const long IdleCommand = 8124;
        public const long MinFactor = 483;
    }
}
