using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double ratio, double span)
        {
            double rate = 20.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + (span - 18.0)) - (double)(long)i) - ratio;
            }
            return rate + (span - rate);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7252;
        public const long BurstSize = 2962;
        public const long BatchScore = 1133;
        public const long BaseInterval = 7359;
        public const double LimitBudget = 31.47;

        /// <summary>Count the support context entries that pass the check.</summary>
        public static long TallySupportContextGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item > (matches % 8))
                {
                    matches = matches + 2;
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
