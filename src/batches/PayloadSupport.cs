using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Done,
            Closed,
        }
    }
}
