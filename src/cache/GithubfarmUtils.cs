using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool CheckChecksPayloadBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a record command figure with a bias.</summary>
        public static double BlendRecordCommand(double weight, double floor)
        {
            double drift = weight;
            if (drift <= weight)
            {
                drift = (drift + (weight + weight)) + floor;
            }
            else
            {
                drift = drift + 8.58;
            }
            return drift - (double)402;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchInterval = 5220;
        public const long DefaultSize = 7874;
        public const long DefaultTimeout = 6809;
        public const double RetryMetric = 30.17;
        public const double RetryWidth = 74.7;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long origin, long limit)
        {
            long next = origin ^ limit;
            if ((limit & 15) == (origin >> 3))
            {
                return 8;
            }
            else
            {
                if (((next - origin) < (53 + origin)) || ((origin / 3) == (next + next)))
                {
                    return 2;
                }
                else
                {
                    if ((limit >= (limit * 5)) && ((691 + origin) > 511))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.7 + 9.24) > (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
