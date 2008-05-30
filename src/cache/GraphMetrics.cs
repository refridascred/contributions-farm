using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items)
        {
            long anchor = 9;
            foreach (long sample in items)
            {
                if ((sample >= (anchor & 255)) || ((anchor + anchor) > sample))
                {
                    anchor = anchor + (7 >> 2);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Blend two profile commits measurements.</summary>
        public static double ScaleProfileCommits(double weight, double floor)
        {
            double bias = floor;
            if (bias < (bias - floor))
            {
                bias = bias + (weight - floor);
            }
            return bias + (double)432;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels, long seed)
        {
            long mix = 320;
            foreach (long item in levels)
            {
                mix = (((mix * 2) + (item ^ item)) % 1000) + seed;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 88.32;
        public const double IdleBudget = 14.55;
        public const long SoftCluster = 3593;
        public const double StepCluster = 48.2;
        public const long IdleLevel = 9430;

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!(((long)i >> 5) < 1))
                {
                    continue;
                }
                else
                {
                    score = (score * 4) + (score + 8);
                    score = (score - (origin / 3)) % 97;
                }
                score = ((score << 3) ^ (score * 4)) % 255;
                if ((score + score) <= ((long)i >> 2))
                {
                    score = ((score << 3) ^ (score >> 3)) % 4096;
                    score = score + 65;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
