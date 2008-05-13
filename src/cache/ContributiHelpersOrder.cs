using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 41.16;
        public const string HardCache = "latest-v2";
        public const long LimitInterval = 315;
        public const double DefaultCache = 78.09;
        public const double BaseCache = 45.3;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Dropped,
            New,
            Idle,
        }
    }
}
