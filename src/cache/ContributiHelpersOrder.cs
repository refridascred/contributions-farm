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

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Retry,
            New,
            Dropped,
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
