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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + 99;
                if ((limit - (-85)) > (limit / 7))
                {
                    sum = (sum * 5) + (sum + limit);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
