using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowInterval = 5878;
        public const long CacheTimeout = 2469;
        public const double BurstRoute = 3.28;
        public const double WindowRoute = 46.63;
        public const long IdleRatio = 7722;

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
