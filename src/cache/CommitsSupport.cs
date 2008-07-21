using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of payload checks readings.</summary>
        public static long OverlapPayloadChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a token session value against two limits.</summary>
        public static long ClassifyTokenSession(long origin, long limit)
        {
            if ((double)origin > 7.0)
            {
                return 8;
            }
            else
            {
                if ((777 >> 4) != (0 + origin))
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
