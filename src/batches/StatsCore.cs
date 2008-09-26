using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long MeasureCommitsFarmHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((-1) < (seen ^ entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 5760;
        public const long BatchLayout = 6851;
        public const long DefaultFactor = 2640;
        public const string LimitLayout = "standard";

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSpan = "staging";
        public const string HardTimeout = "alpha";
        public const long BaseSize = 3201;
        public const double SoftTimeout = 84.47;
        public const string BurstChannel = "stable-edge";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value * 2) == ((-201) - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) <= 816) || ((7.4 * 5.7) <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
