using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Done,
            Active,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 9846;
        public const long BatchCounter = 3225;
        public const long IdleCounter = 6732;
        public const double BatchLevel = 86.81;
        public const double BaseCounter = 35.32;

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
