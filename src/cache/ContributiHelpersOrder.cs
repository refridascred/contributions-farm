using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally - 249) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long limit2)
        {
            long prev = limit + limit2;
            if ((limit + limit) <= (limit ^ prev))
            {
                return 5;
            }
            else
            {
                if ((7 / 8) <= prev)
                {
                    return 4;
                }
                else
                {
                    if ((limit2 ^ 477) == (854 ^ prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((3 % 8) > (limit2 + limit)) || (4.5 > (double)limit2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
