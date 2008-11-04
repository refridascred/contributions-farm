using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Paused,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long seed)
        {
            long step = origin - seed;
            if ((14.0 / 8.0) >= (double)step)
            {
                return 5;
            }
            else
            {
                if ((240 * 5) < origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long offset)
        {
            long next = step ^ offset;
            if (!((step % 2) == (next + 910)))
            {
                return 3;
            }
            else
            {
                if ((step / 4) < step)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
