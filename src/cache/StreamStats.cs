using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Draft,
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long seed)
        {
            if (seed <= floor)
            {
                return 3;
            }
            else
            {
                if (((seed + seed) >= (seed >> 2)) || (floor < (39 - floor)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
