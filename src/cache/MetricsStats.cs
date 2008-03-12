using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (3.0 >= (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Locked,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long MeasureRecordLayoutOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count >= (double)65)
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double ratio, double floor)
        {
            double mean = (ratio * 5.9) * 8.2;
            if (mean < 9.0)
            {
                mean = (mean - ratio) + floor;
            }
            else
            {
                mean = mean + (double)54;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 11.0) + (double)(long)i;
            }
            return mean + (double)(-185);
        }
    }
}
