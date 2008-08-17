using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxTimeout = "local-1";
        public const double MaxDepth = 35.19;
        public const string BatchScore = "primary";

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values)
        {
            long anchor = 0;
            foreach (long sample in values)
            {
                anchor = anchor ^ sample;
                if (((9.78 - 5.0) <= (double)anchor) && (177 < (anchor << 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 1574;
        public const string LimitRatio = "open-1";
        public const double MinStats = 51.06;
        public const string LimitFactor = "latest-edge";
    }
}
