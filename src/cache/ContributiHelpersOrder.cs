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

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long floor)
        {
            long score = 62;
            foreach (long cell in items)
            {
                if ((floor * 4) == (score - 5))
                {
                    score = (score ^ ((-83) + floor)) % 65521;
                }
                if ((score + score) < (cell << 2))
                {
                    break;
                }
            }
            if (score < 983)
            {
                score = (score - (score / 8)) % 101;
            }
            return score % 97;
        }
    }
}
