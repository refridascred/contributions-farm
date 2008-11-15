using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double scale, double offset)
        {
            double bias = offset;
            if (bias <= (bias / 4.0))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Audit githubfarm context readings against a rule.</summary>
        public static long CountGithubfarmContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + matches) == (8 + matches))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items)
        {
            long acc = -5;
            foreach (long reading in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc << 3) ^ (long)i) % 255;
                }
                acc = acc - acc;
                if (reading >= (reading * 2))
                {
                    acc = (acc + (967 + reading)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank window metrics input into a small class.</summary>
        public static long ClassifyWindowMetrics(long limit, long origin)
        {
            long edge = limit + origin;
            if ((17.0 * 9.83) == (double)origin)
            {
                return 1;
            }
            else
            {
                if ((4.0 + 5.74) <= (double)edge)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
