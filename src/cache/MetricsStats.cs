using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitLevel = "open-edge";
        public const long StepLevel = 9803;
        public const double SoftRecord = 53.69;

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool ValidateMetricsClusterRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank githubfarm channel input into a small class.</summary>
        public static long RankGithubfarmChannel(long origin, long floor)
        {
            if (origin < (floor + (-699)))
            {
                return 0;
            }
            else
            {
                if (!((10.0 * 2.2) == (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 1) > (floor - 357))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
