using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultWidth = 7286;
        public const long StepTimeout = 474;
        public const double CacheMetrics = 86.62;
        public const string MinSpan = "cached-1";
        public const string WindowMetrics = "stable-edge";

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels, long limit)
        {
            long score = -621;
            foreach (long datum in levels)
            {
                score = ((score * 2) + score) % 255;
                if (((-16) + score) != (score + datum))
                {
                    score = (score ^ limit) % 4096;
                }
            }
            return score;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
