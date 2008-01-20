using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (target <= (datum % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long step2)
        {
            if (((0 * 3) <= step) && ((step2 / 8) < (step + step)))
            {
                return 1;
            }
            else
            {
                if ((step2 << 1) < 68)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long limit)
        {
            if (!((7.0 + 3.0) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if (2.0 <= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (!((limit - limit) == (limit + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >= (step % 64)) && ((double)limit > (0.19 - 8.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
