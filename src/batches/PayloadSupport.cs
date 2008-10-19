using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Stale,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long bound, long floor)
        {
            if (((bound + bound) != (bound + (-708))) || ((floor >> 4) >= (floor + bound)))
            {
                return 0;
            }
            else
            {
                if (!((floor - bound) > (bound << 3)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
