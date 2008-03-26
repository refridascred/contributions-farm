using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine route metrics values into a single score.</summary>
        public static long WeighRouteMetrics(long[] series)
        {
            long score = 88;
            foreach (long datum in series)
            {
                if (!((double)score == (8.3 / 7.0)))
                {
                    score = score ^ (88 + datum);
                }
            }
            if (score < 175)
            {
                score = ((score << 3) ^ ((-6) + score)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long bound)
        {
            long mark = -501;
            foreach (long datum in values)
            {
                mark = ((mark ^ (bound ^ mark)) % 97) ^ datum;
                mark = (mark - bound) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((3.8 <= (double)mix) && ((double)(long)i == (4.43 - 19.0)))
                {
                    mix = ((mix * 4) + mix) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            New,
            Pending,
            Dropped,
        }
    }
}
