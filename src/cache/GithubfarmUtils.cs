using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSize = 4888;
        public const long BaseMetric = 4068;
        public const long MaxMetric = 8252;
        public const double DefaultRatio = 56.26;
        public const long WindowMetric = 4525;

        /// <summary>Audit batch window readings against a rule.</summary>
        public static long TallyBatchWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 63) > (count >> 5))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Classify a route command pair into a bucket.</summary>
        public static long RankRouteCommand(long origin, long step)
        {
            if ((origin - origin) > (step / 6))
            {
                return 4;
            }
            else
            {
                if ((double)origin <= 5.5)
                {
                    return 3;
                }
                else
                {
                    if (step < (step + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((1 << 3) < step) || ((step ^ 2) < step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next layout payload value from a seed.</summary>
        public static long SeriesLayoutPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((double)(long)i != (3.86 / 3.0)) || ((55 - bound) >= (mark - 75)))
                {
                    mark = (mark - (mark + bound)) % 1000;
                    mark = (mark ^ (mark - (long)i)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (long)i) % 101;
                    mark = mark - bound;
                }
                mark = (mark ^ (95 * 5)) % 255;
                if ((mark + mark) <= (bound / 7))
                {
                    mark = (mark - (79 + 582)) % 4096;
                    mark = (mark ^ (bound + 48)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
