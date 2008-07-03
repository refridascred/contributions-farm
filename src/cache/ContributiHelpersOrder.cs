using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter editor readings against a bound.</summary>
        public static bool GuardFilterEditorBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 9347;
        public const double CacheRoute = 12.34;
        public const string MinTimeout = "alpha-1";
        public const double LimitRoute = 32.75;

        /// <summary>Find the first tools channel entry that matches the target.</summary>
        public static long LocateToolsChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
