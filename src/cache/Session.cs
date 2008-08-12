using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate report context readings against a bound.</summary>
        public static bool ValidateReportContextLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long step, long limit)
        {
            long prev = step - limit;
            if ((limit * 4) == (step & 3))
            {
                return 0;
            }
            else
            {
                if ((prev % 8) != (step << 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit + prev) <= prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev + step) > (step + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Stale,
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Retry,
            Queued,
            Idle,
        }
    }
}
