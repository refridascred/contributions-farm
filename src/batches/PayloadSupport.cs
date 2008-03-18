using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine cache checks values into a single score.</summary>
        public static long FoldCacheChecks(long[] series)
        {
            long state = 26;
            foreach (long item in series)
            {
                if ((state - state) >= 895)
                {
                    state = (state << 3) ^ (item * 3);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long limit, long step)
        {
            long prev = limit - step;
            if ((limit - step) > (355 & 15))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (double)prev)
                {
                    return 0;
                }
                else
                {
                    if (((limit / 9) < (step & 15)) || ((double)step <= (double)limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((prev + (-774)) <= (step << 2)) && ((prev - 24) <= 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
