using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheLevel = 7.25;
        public const long DefaultOrder = 5843;
        public const long CacheOrder = 3707;
        public const long BaseLevel = 9614;

        /// <summary>Validate counter graph readings against a bound.</summary>
        public static bool GuardCounterGraphLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
