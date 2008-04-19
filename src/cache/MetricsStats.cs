using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double gain = (double)(12 + 78);
            if (gain > floor)
            {
                gain = gain + 18.0;
            }
            return gain - (bias - gain);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 15) >= (limit + limit))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a stream stats value against two limits.</summary>
        public static long GradeStreamStats(long target, long seed)
        {
            if ((double)seed >= 3.2)
            {
                return 1;
            }
            else
            {
                if ((target & 3) >= (seed & 127))
                {
                    return 4;
                }
                else
                {
                    if ((double)target == (1.89 * 7.7))
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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 24) == (sample + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen ^ cell) < (19 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
