using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long offset)
        {
            if ((9.38 - 6.56) != (double)target)
            {
                return 5;
            }
            else
            {
                if ((offset % 3) <= (target ^ target))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long step)
        {
            long gap = limit ^ step;
            if ((limit - gap) < (step + limit))
            {
                return 3;
            }
            else
            {
                if (((limit % 10) != (6 ^ step)) && ((6.0 + 18.0) > (double)limit))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the cluster githubfarm entries that pass the check.</summary>
        public static long AuditClusterGithubfarmGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (6 < (tally - reading))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
