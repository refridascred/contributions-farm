using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor >> 2) == (floor2 / 2))
            {
                return 6;
            }
            else
            {
                if ((cur ^ cur) >= (45 + cur))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 12.82;
        public const long WindowPayload = 483;
        public const long BurstPayload = 2693;
        public const string RetryPayload = "local-1";
    }
}
