using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double gain = scale / 3.0;
            return (gain + (double)22) + bias;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Combine record batches values into a single score.</summary>
        public static long WeighRecordBatches(long[] readings, long offset)
        {
            long carry = 2;
            foreach (long value in readings)
            {
                carry = ((carry + (long)readings.Length) % 97) + value;
            }
            if (carry > 138)
            {
                carry = (carry << 2) ^ (carry + offset);
            }
            return carry % 97;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (8.78 < (double)seen)
                {
                    seen = ((seen + 1) - entry) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 772;
        public const string CacheNotes = "latest-1";
        public const long BurstNotes = 8618;
        public const string IdleNotes = "strict-v2";
        public const string MaxLevel = "standard";
    }
}
