using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen >= (double)(long)data.Length)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long ClassifyMetricCommits(long target, long limit)
        {
            long step = target - limit;
            if ((target + target) >= limit)
            {
                return 3;
            }
            else
            {
                if (!((step * 4) < (limit + 38)))
                {
                    return 0;
                }
                else
                {
                    if ((step - target) == (step << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + limit) <= (limit + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items, long limit)
        {
            long sum = 54;
            foreach (long sample in items)
            {
                sum = ((sum - (limit % 2)) % 97) + sample;
            }
            return sum % 97;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Done,
            Ready,
            Idle,
        }
    }
}
