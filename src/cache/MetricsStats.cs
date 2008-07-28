using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long seed)
        {
            long score = 971;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length != (double)seed)
                {
                    score = ((score << 2) ^ (seed / 6)) ^ reading;
                }
            }
            return score;
        }

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long TallyGithubfarmBatchOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((target * 4) <= (matches + target))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi route entries that pass the check.</summary>
        public static long CountContributiRouteHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((3.0 - 7.0) != (double)hits) || !((double)hits > (3.11 * 2.05)))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long result = 40;
            foreach (long entry in samples)
            {
                if ((double)result >= (17.0 / 4.0))
                {
                    break;
                }
                if ((double)entry == (5.4 - 2.9))
                {
                    result = ((result << 2) ^ ((long)samples.Length ^ entry)) % 65521;
                }
                else
                {
                    result = (result + result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 9816;
        public const long WindowSupport = 1160;
        public const long RetrySupport = 9876;
    }
}
