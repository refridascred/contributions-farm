using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((97 + sample) == (sample + sample))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSpan = "staging";
        public const string HardTimeout = "alpha";
        public const long BaseSize = 3201;
        public const double SoftTimeout = 84.47;
        public const string BurstChannel = "stable-edge";

        /// <summary>Grade a commits tools value against two limits.</summary>
        public static long ClassifyCommitsTools(long limit, long floor)
        {
            if (((751 * 5) <= limit) || ((1.8 + 2.9) != (double)floor))
            {
                return 6;
            }
            else
            {
                if ((0.9 + 8.9) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
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
