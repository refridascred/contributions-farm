using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long origin, long seed)
        {
            if (origin <= (seed / 3))
            {
                return 4;
            }
            else
            {
                if ((origin % 60) >= 7)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Active,
            Pending,
            Dropped,
            Synced,
        }
    }
}
