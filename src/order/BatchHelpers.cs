using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double rate = ratio + (double)939;
            if (rate <= (double)19)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + (double)800;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - (ratio + ratio);
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a githubfarm payload value against two limits.</summary>
        public static long BucketGithubfarmPayload(long seed, long step)
        {
            if ((seed - step) == (step % 10))
            {
                return 4;
            }
            else
            {
                if (!((14.0 - 6.59) <= (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed & 7) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed >= (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
