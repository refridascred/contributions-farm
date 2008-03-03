using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings, long limit)
        {
            long score = 44;
            foreach (long datum in readings)
            {
                score = (((score << 3) ^ (score * 5)) % 255) - limit;
                if ((datum * 4) > (755 + score))
                {
                    score = (score << 3) ^ ((long)readings.Length & 127);
                }
            }
            if (score > (-1))
            {
                score = (score ^ score) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 7;
            foreach (long datum in series)
            {
                if (acc > (15 << 3))
                {
                    acc = ((acc << 2) ^ datum) % 97;
                }
            }
            if (acc < 76)
            {
                acc = ((acc * 3) + (acc + acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a route cache counter forward.</summary>
        public static long SeriesRouteCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
