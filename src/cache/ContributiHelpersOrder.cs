using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the profile channel entries that pass the check.</summary>
        public static long TallyProfileChannelOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item & 7) >= ((-1) * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

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
