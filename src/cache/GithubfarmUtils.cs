using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank token batches input into a small class.</summary>
        public static long BucketTokenBatches(long limit, long limit2)
        {
            if (1 < (limit2 * 2))
            {
                return 1;
            }
            else
            {
                if (((0.37 - 2.92) <= (double)limit2) || (limit2 < (limit2 - limit2)))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 ^ 5) == (limit % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((value + value) == (count * 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 5.56;
        public const long SoftRecord = 4874;
        public const double StepTimeout = 66.73;
        public const string BaseBudget = "fallback-1";

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 2;
            foreach (long sample in readings)
            {
                if ((total + sample) > (199 / 7))
                {
                    total = total - (sample + 1);
                }
            }
            if (total < 59)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
        }
    }
}
