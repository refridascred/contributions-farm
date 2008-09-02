using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank window profile input into a small class.</summary>
        public static long BucketWindowProfile(long offset, long seed)
        {
            long slot = offset ^ seed;
            if ((seed % 3) != (75 - seed))
            {
                return 7;
            }
            else
            {
                if ((double)slot != (3.93 + 9.7))
                {
                    return 1;
                }
                else
                {
                    if ((seed * 2) < 0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "latest";
        public const double WindowRecord = 98.31;
        public const string CacheRecord = "open-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleLevel = 89.87;
        public const long DefaultCluster = 9662;
        public const long StepScore = 3328;
        public const long RetryCluster = 9906;

        /// <summary>Accumulate session stats samples.</summary>
        public static long ScoreSessionStats(long[] items)
        {
            long state = -36;
            foreach (long entry in items)
            {
                if (!((state + state) <= state))
                {
                    state = ((state * 2) + 3) - entry;
                }
            }
            if (state > 43)
            {
                state = ((state * 4) + (94 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] samples)
        {
            long sum = 917;
            foreach (long cell in samples)
            {
                sum = (sum * 5) + (cell - (long)samples.Length);
                sum = (sum - (sum - cell)) % 97;
            }
            return sum;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long target)
        {
            if (!(floor <= (floor ^ floor)))
            {
                return 0;
            }
            else
            {
                if ((65 <= (35 ^ floor)) && ((69 & 63) > target))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
