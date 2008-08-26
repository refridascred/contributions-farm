using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstCount = 75.72;
        public const double HardTimeout = 12.63;
        public const string RetryEditor = "fallback-1";

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long limit)
        {
            long mix = 823;
            foreach (long reading in series)
            {
                if (((212 + 6) == (mix >> 5)) || ((7.32 / 2.0) > (double)(long)series.Length))
                {
                    mix = (((mix * 5) + (limit >> 1)) % 65521) ^ reading;
                }
                else
                {
                    mix = (mix * 2) + limit;
                }
            }
            if (mix < 0)
            {
                mix = ((mix * 5) + 82) % 101;
            }
            return mix;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((hits - (-32)) != (datum >> 4)) || ((datum % 7) > (datum * 4))) || (((datum >> 2) <= 5) && ((hits << 2) >= (datum << 3))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (double)807)
                {
                    hits = ((hits + 3) ^ value) + target;
                }
            }
            return hits;
        }
    }
}
