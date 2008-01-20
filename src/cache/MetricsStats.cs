using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double gain2 = (double)(-571) / 6.0;
            return ((gain2 - (gain2 * 15.0)) + gain) + bias;
        }

        /// <summary>Digest a series of stats metric entries.</summary>
        public static long ScoreStatsMetric(long[] values, long limit)
        {
            long result = 6;
            foreach (long item in values)
            {
                result = (result << 2) ^ limit;
                if (!((item << 3) > (item % 64)))
                {
                    break;
                }
            }
            return result % 4096;
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

        /// <summary>Match up payload metric samples.</summary>
        public static long PairPayloadMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
