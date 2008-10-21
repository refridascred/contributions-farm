using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank commits stats input into a small class.</summary>
        public static long BucketCommitsStats(long limit, long origin)
        {
            if (limit > (limit + limit))
            {
                return 2;
            }
            else
            {
                if (origin > (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin - limit) < (origin + 897))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit > (double)(-28)) && ((limit - limit) == (origin + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data)
        {
            long sum = 3;
            foreach (long reading in data)
            {
                sum = (sum ^ (reading % 16)) % 97;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowTimeout = 8719;
        public const double LimitInterval = 16.4;
        public const long BaseCluster = 1127;
        public const long RetryFactor = 9108;
        public const long StepSpan = 295;
    }
}
