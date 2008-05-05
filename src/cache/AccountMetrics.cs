using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen * 3) >= (sample / 3)) && ((seen >> 1) == (sample / 8)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double ratio, double bias)
        {
            double load = (double)(8 + 422);
            return ((load + (10.0 - 0.09)) + ratio) + bias;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank layout payload input into a small class.</summary>
        public static long RankLayoutPayload(long origin, long origin2)
        {
            if (570 < origin)
            {
                return 6;
            }
            else
            {
                if (!((origin2 - origin2) >= (origin2 - origin)))
                {
                    return 5;
                }
                else
                {
                    if (14.0 > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (5.87 * 8.1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
