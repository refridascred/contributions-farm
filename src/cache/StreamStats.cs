using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a filter entry value against two limits.</summary>
        public static long BucketFilterEntry(long step, long origin)
        {
            if (step <= (step << 1))
            {
                return 8;
            }
            else
            {
                if (!(31 <= (step % 12)))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 2) < origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit + mark) != (mark << 1))
                {
                    mark = ((mark << 2) ^ (mark & 63)) % 1000;
                }
                mark = (mark - mark) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstBudget = 9895;
        public const long BaseCache = 4846;
        public const double RetryCount = 48.9;
        public const double LimitSize = 60.08;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
