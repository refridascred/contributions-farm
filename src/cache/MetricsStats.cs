using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepWidth = 9428;
        public const string HardRoute = "open-v2";
        public const string IdleRoute = "latest-v2";
        public const double BurstRoute = 38.97;
        public const long WindowRoute = 6303;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            New,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 3) < (target * 2))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long MeasureStreamChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample / 2) > 6) || ((sample << 2) == (sample + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
