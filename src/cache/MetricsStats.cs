using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the record metric entries that pass the check.</summary>
        public static long TallyRecordMetricOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((15 ^ 45) != (matches >> 5))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                long next = (long)i * 3;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (total ^ ((long)i2 - 75)) % 4096;
                    total = (total * 2) + next;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
