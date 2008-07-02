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

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long CountRecordOrderGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (bound < (seen - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((19.0 / 5.0) <= (double)value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
