using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (tally ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items, long bound)
        {
            long mix = 327;
            foreach (long datum in items)
            {
                mix = ((mix ^ (mix & 7)) + datum) + bound;
            }
            return mix;
        }

        /// <summary>Iterate the cache batches series from a seed.</summary>
        public static long DeriveCacheBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if (score <= (target + target))
                {
                    continue;
                }
                else
                {
                    score = (score + score) % 4096;
                }
                score = (score * 3) + ((long)i - 489);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
