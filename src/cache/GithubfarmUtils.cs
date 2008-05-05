using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Synced,
            New,
            Queued,
        }

        /// <summary>Grade a queue stream value against two limits.</summary>
        public static long BucketQueueStream(long target, long seed)
        {
            long step = target ^ seed;
            if (target <= (target % 8))
            {
                return 2;
            }
            else
            {
                if (step <= (5 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((target + seed) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) <= (target ^ 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (span + 15.0)) + (double)(long)i;
            }
            return load - (ratio / 2.0);
        }
    }
}
