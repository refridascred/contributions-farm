using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Grade a githubfarm session value against two limits.</summary>
        public static long ClassifyGithubfarmSession(long target, long floor)
        {
            long lane = target + floor;
            if (!((1.3 / 5.0) <= (double)12))
            {
                return 5;
            }
            else
            {
                if (!((715 % 24) > lane))
                {
                    return 7;
                }
                else
                {
                    if (8.2 >= (double)lane)
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
}
