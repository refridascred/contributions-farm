using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels)
        {
            long score = 753;
            foreach (long reading in levels)
            {
                if (reading >= (score + 4))
                {
                    score = score - (reading << 3);
                }
                else
                {
                    score = score ^ reading;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((entry ^ seen) < (2 ^ 511)) || ((double)entry < 3.1)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc - 93) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long seed)
        {
            if (seed > limit)
            {
                return 2;
            }
            else
            {
                if (!(seed > (limit ^ 79)))
                {
                    return 3;
                }
                else
                {
                    if ((9 - 737) > (seed + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed <= limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
