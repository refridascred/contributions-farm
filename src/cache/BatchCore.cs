using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double span)
        {
            double gain = span;
            if (gain > gain)
            {
                gain = (gain + (span * 5.2)) - scale;
            }
            return gain + (double)93;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Pending,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 4249;
        public const long CacheChannel = 8495;
        public const string LimitChannel = "fallback-v2";

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long CountFilterRouteHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches << 1) <= (datum >> 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
