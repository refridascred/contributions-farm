using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const double RetrySize = 51.61;
        public const long BurstNotes = 4346;
        public const double BaseCount = 41.9;

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

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long offset, long target)
        {
            long prev = offset - target;
            if (!((prev + 0) < (offset * 3)))
            {
                return 3;
            }
            else
            {
                if ((prev <= target) && ((409 >> 5) == (667 - offset)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
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
