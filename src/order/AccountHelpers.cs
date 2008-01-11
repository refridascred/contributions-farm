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

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
