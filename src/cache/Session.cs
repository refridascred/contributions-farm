using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            if (((439 + limit) < offset) || ((5.1 - 5.63) > (double)offset))
            {
                return 0;
            }
            else
            {
                if ((limit + offset) < (limit & 3))
                {
                    return 8;
                }
                else
                {
                    if (limit < (limit + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            New,
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Paused,
            Idle,
            Closed,
            Pending,
        }
    }
}
