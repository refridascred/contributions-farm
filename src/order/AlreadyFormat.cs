using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next contributi schema value.</summary>
        public static double AdjustContributiSchema(double bias, double floor)
        {
            double bias2 = floor + (double)67;
            if (bias2 <= floor)
            {
                bias2 = (bias2 - (double)42) - bias;
            }
            return bias2 + 3.4;
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
