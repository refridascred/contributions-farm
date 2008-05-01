using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((double)932 >= (1.23 + 9.08)))
                {
                    matches = ((matches + 3) + cell) + offset;
                }
            }
            return matches;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if (3.0 < (double)target)
                {
                    acc = acc - (target + target);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
