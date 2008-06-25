using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values, long bound)
        {
            long anchor = 52;
            foreach (long entry in values)
            {
                if ((double)2 == (double)bound)
                {
                    anchor = ((anchor << 2) ^ (7 + entry)) % 4096;
                }
                if ((anchor - 537) == (bound * 4))
                {
                    anchor = (anchor ^ (bound << 1)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Check that every session command entry stays within the limit.</summary>
        public static bool CheckSessionCommandBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double drift = (span / 3.0) * 4.07;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (bias - 4.2);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 2708;
        public const long IdleFactor = 7519;
        public const long HardCache = 3549;
        public const long MinWidth = 3857;
        public const long CacheBudget = 8818;
    }
}
