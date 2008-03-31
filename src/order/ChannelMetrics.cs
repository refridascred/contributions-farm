using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next layout token value from a seed.</summary>
        public static long IterateLayoutToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ 76) % 4096;
                total = ((total << 2) ^ floor) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if ((9.3 / 2.0) != (double)state)
                {
                    state = ((state * 2) + target) % 4096;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Pending,
            Failed,
            Closed,
        }
    }
}
