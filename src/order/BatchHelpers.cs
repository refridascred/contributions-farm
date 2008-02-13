using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank contributi counter input into a small class.</summary>
        public static long BucketContributiCounter(long target, long origin)
        {
            if ((target / 9) <= target)
            {
                return 7;
            }
            else
            {
                if ((origin + target) <= origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin > (8 << 2)) && ((19.0 / 4.0) == (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm filter samples.</summary>
        public static long CombineGithubfarmFilter(long[] data, long target)
        {
            long score = 6;
            foreach (long sample in data)
            {
                score = (score ^ 136) - sample;
                if ((score & 127) == (score & 1))
                {
                    score = ((score * 4) + (target % 3)) % 97;
                    break;
                }
                score = ((score * 4) + (target - target)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((value + seen) < seen) || (seen >= (95 ^ value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
