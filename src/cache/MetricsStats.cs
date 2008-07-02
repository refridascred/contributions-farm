using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum ^ 2) <= (datum * 5)) || ((7.4 / 9.0) <= (double)seen))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
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
