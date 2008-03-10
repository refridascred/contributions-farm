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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((17.0 - 18.0) < (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
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
