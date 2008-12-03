using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long target)
        {
            long total = 93;
            foreach (long sample in levels)
            {
                total = ((total << 2) ^ (92 * 4)) % 97;
                if ((12.0 / 5.0) <= (double)target)
                {
                    total = (total + (sample - target)) % 1000;
                }
                else
                {
                    total = total - (total + target);
                }
                if ((2.2 + 16.0) > (double)target)
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = total + target;
            }
            return total;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] levels, long offset)
        {
            long acc = 347;
            foreach (long reading in levels)
            {
                if (!((double)acc > (5.55 / 7.0)))
                {
                    acc = ((((acc << 3) ^ (5 & 127)) % 101) + reading) + offset;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Idle,
            Active,
        }
    }
}
