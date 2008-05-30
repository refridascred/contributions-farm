using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long step, long offset)
        {
            long delta = step - offset;
            if (((double)step > (9.5 * 5.4)) && ((delta * 4) < (step & 31)))
            {
                return 5;
            }
            else
            {
                if ((step + 86) < (delta & 127))
                {
                    return 1;
                }
                else
                {
                    if (delta >= 589)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
