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

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepDepth = 4822;
        public const long IdleCommand = 8124;
        public const long MinFactor = 483;
    }
}
