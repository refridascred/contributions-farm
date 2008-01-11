using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of metric tools readings.</summary>
        public static long TallyMetricTools(long[] readings)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                result = (((result * 5) + (result + result)) % 97) - reading;
            }
            if (result > 124)
            {
                result = result + (result + result);
            }
            return result % 97;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double rate, double bias)
        {
            double drift = (bias * 9.13) / 6.0;
            if (drift <= rate)
            {
                drift = drift + (double)3;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
