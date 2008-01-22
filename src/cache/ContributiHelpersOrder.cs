using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string RetryLevel = "alpha";
        public const long MaxContext = 4006;
        public const long RetryContext = 7878;
        public const double WindowContext = 77.51;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(((reading + count) >= count) && (((long)levels.Length - 16) >= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((3.3 / 6.0) != (double)floor) && ((double)floor != (double)895))
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
