using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank session filter input into a small class.</summary>
        public static long BucketSessionFilter(long target, long step)
        {
            if (!(2 <= (step + target)))
            {
                return 4;
            }
            else
            {
                if ((step * 4) >= step)
                {
                    return 3;
                }
                else
                {
                    if (1 < (step & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.1 * 6.3) == (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] values)
        {
            long score = 0;
            foreach (long entry in values)
            {
                score = (score ^ score) + entry;
            }
            return score % 65521;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((item + 0) < (7 + item)) || ((tally + tally) == (item ^ tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first queue batch entry that matches the target.</summary>
        public static long FindQueueBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 2832;
        public const long CacheWidth = 8448;
        public const double RetryStream = 26.19;
        public const string LimitStream = "cached-v2";
    }
}
