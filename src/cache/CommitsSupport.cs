using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepScore = 82.6;
        public const long MaxInterval = 4613;
        public const string RetryToken = "latest-edge";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route stats value against two limits.</summary>
        public static long RankRouteStats(long bound, long seed)
        {
            if (((-58) & 255) <= (bound << 1))
            {
                return 0;
            }
            else
            {
                if (!((bound + bound) > bound))
                {
                    return 3;
                }
                else
                {
                    if ((seed & 255) <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound >= 1.3)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
