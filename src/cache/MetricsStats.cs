using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((3.96 * 2.9) != (double)reading)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally > (6.2 / 3.0))
                {
                    tally = ((tally + 2) + reading) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((538 >> 2) > (matches - matches)) && ((237 ^ matches) >= (item - (-4)))) || ((matches + item) != (matches * 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 5239;
        public const string WindowTools = "alpha-edge";
        public const string BurstTools = "alpha-v2";
        public const long LimitBudget = 2304;
        public const double LimitTools = 21.97;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 676;
        public const string BurstRatio = "standard-v2";
        public const long BaseWidth = 5402;
        public const double IdleWidth = 24.56;
    }
}
