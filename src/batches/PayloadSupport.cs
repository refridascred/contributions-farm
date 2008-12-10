using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long origin)
        {
            if ((origin >= (origin >> 4)) || ((origin % 60) < bound))
            {
                return 2;
            }
            else
            {
                if ((24 + 463) != (bound % 7))
                {
                    return 0;
                }
                else
                {
                    if (!((bound - origin) >= (bound / 9)))
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

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
