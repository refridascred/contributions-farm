using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long floor)
        {
            if (7 < step)
            {
                return 7;
            }
            else
            {
                if ((725 * 4) == (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
