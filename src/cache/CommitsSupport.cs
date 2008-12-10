using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a metrics tools sample.</summary>
        public static long LocateMetricsToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long origin2)
        {
            if (((origin2 / 8) < (origin * 5)) && ((origin2 + origin) >= (origin + origin2)))
            {
                return 6;
            }
            else
            {
                if ((origin / 5) > origin2)
                {
                    return 0;
                }
                else
                {
                    if ((origin * 4) < (origin2 + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - origin) > (origin2 / 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a support commits value against two limits.</summary>
        public static long BucketSupportCommits(long step, long step2)
        {
            long prev = step - step2;
            if ((prev / 9) > (prev << 2))
            {
                return 8;
            }
            else
            {
                if ((3.52 - 9.07) <= (double)step2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double rate = span;
            if (rate >= (3.9 / 8.0))
            {
                rate = (rate - rate) - ratio;
            }
            return rate + (rate - span);
        }
    }
}
