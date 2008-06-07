using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally >> 3) < (entry - tally)) || ((9 % 2) > (entry * 4)))
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((tally + limit) > (tally / 2)) && (746 >= tally)) || (78 > (limit + limit)))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 40.76;
        public const long DefaultMetrics = 6011;
        public const long MinScore = 426;
        public const long BaseMetrics = 5646;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstRatio = 9664;
        public const double SoftScore = 27.6;
        public const long BatchStats = 7058;
        public const string DefaultCount = "fallback";
    }
}
