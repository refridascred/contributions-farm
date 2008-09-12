using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long target)
        {
            if ((-8) >= step)
            {
                return 8;
            }
            else
            {
                if ((step ^ 1) != (5 - target))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches > 6)
                {
                    matches = ((matches + 1) + entry) - seed;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of counter tools readings.</summary>
        public static long OverlapCounterToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items)
        {
            long result = 622;
            foreach (long datum in items)
            {
                if ((double)datum <= 14.0)
                {
                    result = (result << 2) ^ result;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            Draft,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchBudget = 48.46;
        public const double RetryRoute = 50.35;
        public const double IdleRoute = 64.99;
        public const long BurstRoute = 347;
    }
}
