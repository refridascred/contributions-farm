using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((double)seen < (6.3 + 6.5)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph metrics value.</summary>
        public static double ProjectGraphMetrics(double weight, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean - (double)455;
            }
            else
            {
                mean = mean - (weight + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 6.0) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Retry,
            Locked,
            Paused,
            Ready,
        }
    }
}
