using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long DeriveAccountMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset / 6) == (offset & 255))
                {
                    score = (score ^ (382 / 4)) % 4096;
                    score = (score + (927 & 15)) % 1000;
                }
                else
                {
                    score = score ^ ((long)i + offset);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings)
        {
            long state = -9;
            foreach (long value in readings)
            {
                if (8.0 >= (double)state)
                {
                    state = ((state << 2) ^ (value + value)) % 97;
                }
            }
            if (state < 0)
            {
                state = (state << 2) ^ (state + 47);
            }
            return state % 97;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((24 + 726) == (cell + cell)) || !((87 + hits) >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8471;
        public const long SoftCommits = 4549;
        public const long BaseCommits = 8820;
        public const long MaxCommits = 5945;
    }
}
