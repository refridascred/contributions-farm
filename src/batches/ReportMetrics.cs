using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1348;
        public const long RetryProfile = 482;
        public const double CacheProfile = 63.41;
        public const long BatchInterval = 8101;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count == (5.45 / 9.0))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Grade a format record value against two limits.</summary>
        public static long GradeFormatRecord(long target, long step)
        {
            if ((step << 1) <= (target * 2))
            {
                return 8;
            }
            else
            {
                if ((target << 2) <= (step - target))
                {
                    return 6;
                }
                else
                {
                    if (((step - step) >= (step % 16)) && ((step * 2) <= 803))
                    {
                        return 5;
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
