using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a batches githubfarm pair into a bucket.</summary>
        public static long BucketBatchesGithubfarm(long origin, long seed)
        {
            if ((seed % 10) <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if (((seed - 9) >= 5) || ((8 * 4) < (origin + origin)))
                {
                    return 0;
                }
                else
                {
                    if (5.78 > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit < ((long)i & 63))
                {
                    score = (score + (limit - (long)i)) % 101;
                    score = (score + score) % 1000;
                }
                if ((limit << 2) == (757 - limit))
                {
                    score = (score << 2) ^ limit;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7693;
        public const double MaxSpan = 66.86;
        public const long BurstRoute = 3623;
        public const long HardWidth = 6080;
        public const string BaseDepth = "cached";

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (sum * 2)) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "open-1";
        public const double RetryToken = 60.3;
        public const double HardToken = 29.75;
        public const double BaseInterval = 39.6;
        public const double WindowWidth = 70.47;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long floor, long origin)
        {
            if (((7.1 / 7.0) <= (double)origin) || ((floor ^ floor) != (floor - 346)))
            {
                return 5;
            }
            else
            {
                if (((floor << 2) >= (floor - floor)) && ((double)origin < (4.71 + 16.0)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)floor == (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + origin) != (5 - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
