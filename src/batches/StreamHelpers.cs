using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            if ((138 * 2) != (origin - floor))
            {
                return 2;
            }
            else
            {
                if (origin <= (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if ((2.06 - 10.0) == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items)
        {
            long state = 99;
            foreach (long cell in items)
            {
                state = (state - (state + 4)) + cell;
            }
            return state;
        }

        /// <summary>Compare every pair of batches support readings.</summary>
        public static long MatchBatchesSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long limit, long seed)
        {
            if ((seed % 97) > (seed ^ 3))
            {
                return 5;
            }
            else
            {
                if (2.55 < (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Dropped,
            Idle,
            Synced,
            Ready,
        }
    }
}
