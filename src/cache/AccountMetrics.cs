using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Classify a channel stream pair into a bucket.</summary>
        public static long BucketChannelStream(long floor, long target)
        {
            if (target > (target / 2))
            {
                return 2;
            }
            else
            {
                if ((1.78 / 2.0) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
