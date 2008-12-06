using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate format queue readings against a bound.</summary>
        public static bool VerifyFormatQueueRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long TallyGithubfarmChecks(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                total = (total << 2) ^ (sample - sample);
            }
            if (total > 332)
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double ratio, double offset)
        {
            double rate = 0.42;
            for (int i = 0; i < 3; i++)
            {
                rate = (((rate + (6.0 * 11.0)) + (double)(long)i) + ratio) + offset;
            }
            return rate + (rate + 14.0);
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long floor)
        {
            long prev = step + floor;
            if ((double)floor <= (double)prev)
            {
                return 2;
            }
            else
            {
                if ((double)prev >= (double)863)
                {
                    return 6;
                }
                else
                {
                    if (!((double)step >= 5.72))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Stale,
            Locked,
            Failed,
        }
    }
}
