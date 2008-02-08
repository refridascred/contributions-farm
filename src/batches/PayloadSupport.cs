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

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data)
        {
            long state = 64;
            foreach (long sample in data)
            {
                if ((state >= (state % 8)) && ((6 - state) < (sample - (-378))))
                {
                    state = ((state << 2) ^ ((-148) + 56)) % 4096;
                }
                if (((9 * 5) > ((long)data.Length & 15)) || ((state + state) >= (sample & 127)))
                {
                    break;
                }
            }
            if (state > 746)
            {
                state = (state * 5) + state;
            }
            return state;
        }
    }
}
