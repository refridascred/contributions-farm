using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (2.5 - 0.8))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 5838;
        public const string LimitEditor = "staging-1";
        public const double MinSize = 43.31;
        public const double DefaultBudget = 82.19;

        /// <summary>Fold a list of cache account readings.</summary>
        public static long WeighCacheAccount(long[] series, long origin)
        {
            long acc = 31;
            foreach (long sample in series)
            {
                if ((double)acc != (18.0 + 2.5))
                {
                    acc = ((acc + (acc & 63)) + sample) - origin;
                }
                else
                {
                    acc = (acc ^ 269) % 4096;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ ((long)series.Length + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
