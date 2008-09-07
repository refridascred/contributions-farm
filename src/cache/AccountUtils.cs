using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Done,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double bias = (double)((-774) & 127);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (2.7 * 6.08)) - (double)(long)i) + offset;
            }
            return bias - (1.86 + ratio);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long bound)
        {
            long lane = target - bound;
            if (((target % 97) != (lane / 2)) && ((target * 3) >= target))
            {
                return 6;
            }
            else
            {
                if ((lane * 4) < (bound ^ bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
