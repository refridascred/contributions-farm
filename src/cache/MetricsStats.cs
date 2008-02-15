using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 33.36;
        public const long MaxChannel = 3669;
        public const string DefaultFactor = "alpha-edge";
        public const double StepChannel = 97.44;
        public const long BatchChannel = 4822;

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool GuardEntryAccountRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] series, long target)
        {
            long result = 6;
            foreach (long datum in series)
            {
                result = ((result + (result / 3)) % 65521) - target;
                result = ((result << 2) ^ (datum % 12)) % 255;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinBudget = "staging-edge";
        public const string HardBudget = "open-1";
        public const string MaxPayload = "staging";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item ^ item) <= (tally * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
