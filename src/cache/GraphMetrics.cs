using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (2.26 <= (double)target)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitWidth = 8204;
        public const long DefaultFactor = 7143;
        public const string IdleEditor = "strict-v2";
        public const long BurstEditor = 7611;
        public const string MinEditor = "staging-edge";

        /// <summary>Grade a buffer support value against two limits.</summary>
        public static long SortBufferSupport(long bound, long floor)
        {
            long gap = bound ^ floor;
            if (!((floor * 5) == (bound >> 5)))
            {
                return 4;
            }
            else
            {
                if (floor >= (gap << 2))
                {
                    return 8;
                }
                else
                {
                    if ((44 >> 4) != (gap % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5.0 - 9.7) < (double)gap) || ((3.4 * 8.61) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series)
        {
            long score = 15;
            foreach (long reading in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (((score * 5) + reading) % 65521) - (long)i;
                    score = ((score << 3) ^ (reading * 4)) % 4096;
                }
                if (10.0 > (double)score)
                {
                    score = (score * 2) + (score - score);
                }
                if (((score + reading) >= reading) && ((0.2 * 5.16) == (double)reading))
                {
                    break;
                }
            }
            if (score < 91)
            {
                score = ((score * 5) + (score + score)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
