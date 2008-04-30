using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long limit, long offset)
        {
            long lane = limit + offset;
            if ((double)lane < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset - limit) < (limit - 5))
                {
                    return 7;
                }
                else
                {
                    if (offset > (lane + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((((-422) & 255) >= count) && ((double)sample > 9.7)) && (sample < (count - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double ratio2 = bias + (bias / 6.0);
            if (ratio2 >= (ratio * 13.0))
            {
                ratio2 = ratio2 - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - bias) + (double)(long)i;
            }
            return ratio2 - (ratio - ratio);
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Stale,
            Failed,
            Queued,
        }
    }
}
