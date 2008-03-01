using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Failed,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long seed)
        {
            if (5 >= (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((4.2 - 9.2) > (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank command payload input into a small class.</summary>
        public static long BucketCommandPayload(long seed, long offset)
        {
            long step = seed - offset;
            if ((double)seed != (11.0 - 4.6))
            {
                return 8;
            }
            else
            {
                if ((0.1 / 5.0) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((step << 3) <= (step + 43)) && ((9.0 / 3.0) == (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset ^ seed) > (offset + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
