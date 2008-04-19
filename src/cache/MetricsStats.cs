using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double scale = 19.0 - (double)(-237);
            if (scale > (5.9 - 20.0))
            {
                scale = (scale - span) - weight;
            }
            else
            {
                scale = scale - (double)5;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale + scale)) + (double)(long)i;
            }
            return scale + scale;
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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((step + entry) >= 949)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
