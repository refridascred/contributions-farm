using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long target2)
        {
            long next = target ^ target2;
            if ((target <= (target + 780)) || ((target / 8) < (target2 + target2)))
            {
                return 2;
            }
            else
            {
                if (((314 - next) < (next - target)) && (next < 708))
                {
                    return 0;
                }
                else
                {
                    if (!(2 <= (next + 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target2 & 31) > target) || (next <= (target - 499)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            New,
            Failed,
            Closed,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Combine report githubfarm values into a single score.</summary>
        public static long FoldReportGithubfarm(long[] values, long step)
        {
            long anchor = -1;
            foreach (long cell in values)
            {
                anchor = anchor - (long)values.Length;
                if ((step & 7) > (9 ^ cell))
                {
                    break;
                }
            }
            if (anchor < 53)
            {
                anchor = (anchor * 5) + (3 >> 4);
            }
            return anchor;
        }
    }
}
