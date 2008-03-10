using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Ready,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm contributi pair into a bucket.</summary>
        public static long BucketGithubfarmContributi(long target, long floor)
        {
            long bound = target - floor;
            if (!((5.0 / 3.0) > (double)bound))
            {
                return 3;
            }
            else
            {
                if (8.38 < (double)target)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
