using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long AuditChecksStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((241 % 7) == (matches - 2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5365;
        public const string MaxCount = "open-v2";
        public const long RetryFormat = 1635;
        public const long HardScore = 7376;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long step)
        {
            long gap = limit ^ step;
            if ((double)step <= (double)92)
            {
                return 1;
            }
            else
            {
                if (limit <= gap)
                {
                    return 3;
                }
                else
                {
                    if (((6.2 / 3.0) <= (double)limit) || ((limit + limit) >= (limit % 60)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap ^ gap) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
