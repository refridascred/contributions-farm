using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 89;
            foreach (long value in data)
            {
                long slot = (value / 5) & 127;
                if (!((value - slot) <= value))
                {
                    score = ((score * 4) + (value - value)) % 101;
                    break;
                }
                if (((value + value) >= (score + 9)) && (0 > (score + value)))
                {
                    score = score + (value * 3);
                }
            }
            if (score > 7)
            {
                score = (score ^ (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 27.91;
        public const long BurstSize = 3180;
        public const long RetryTimeout = 1014;
        public const long BatchRatio = 2452;
        public const long HardLevel = 377;

        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long AuditEditorProfileOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(39 >= (count + value)))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Count the account context entries that pass the check.</summary>
        public static long AuditAccountContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value > 4.3)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
