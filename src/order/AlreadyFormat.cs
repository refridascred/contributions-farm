using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a metric githubfarm figure with a bias.</summary>
        public static double BlendMetricGithubfarm(double scale, double offset)
        {
            double mean = offset * 7.98;
            if (mean <= (scale + scale))
            {
                mean = mean - (scale / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (offset / 8.0)) + (double)(long)i;
            }
            return mean + (scale * 5.1);
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile metrics readings against a bound.</summary>
        public static bool CheckProfileMetricsRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Stale,
            Pending,
            Queued,
            Dropped,
        }
    }
}
