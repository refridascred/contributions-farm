using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks githubfarm pair into a bucket.</summary>
        public static long BucketChecksGithubfarm(long limit, long seed)
        {
            long slot = limit ^ seed;
            if ((slot * 3) > seed)
            {
                return 0;
            }
            else
            {
                if (935 < (seed ^ 563))
                {
                    return 2;
                }
                else
                {
                    if (!((13.0 / 8.0) <= (double)slot))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.9 / 5.0) <= (1.38 + 8.35))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Pending,
            Active,
            Done,
            Stale,
        }
    }
}
