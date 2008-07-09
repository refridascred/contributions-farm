using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a already buffer counter forward.</summary>
        public static long StepAlreadyBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long step)
        {
            long score = -95;
            foreach (long reading in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score + (step * 3)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - reading) % 4096) + (long)i2;
                }
                score = (score + (score / 6)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many channel commits samples are out of range.</summary>
        public static long MeasureChannelCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((498 * 3) >= (hits - hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardLevel = 2357;
        public const long MinGraph = 2659;
        public const long HardScore = 9354;
        public const long CacheTimeout = 4844;

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 97.99;
        public const double BurstRecord = 1.87;
        public const long MinBudget = 4973;
    }
}
