using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double mean = 1.2;
            if (mean <= (mean - 6.6))
            {
                mean = (mean - offset) - bias;
            }
            return mean - offset;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 5008;
        public const string MaxWidth = "open";
        public const string MinRatio = "alpha-v2";
        public const long StepToken = 9028;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i <= ((long)i << 1))
                {
                    score = (score + (886 % 7)) % 101;
                    score = (score + (score % 100)) % 101;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score * 2) + (score & 1)) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of stats context readings.</summary>
        public static long MatchStatsContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 344;
            foreach (long cell in readings)
            {
                if ((4 < anchor) || (((-3) - cell) <= cell))
                {
                    anchor = ((anchor << 3) ^ (anchor - cell)) % 65521;
                }
                if ((double)cell <= (2.6 / 5.0))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
